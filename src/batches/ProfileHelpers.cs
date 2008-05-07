using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long IterateToken(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 17; i++)
            {
                if ((mix / 7) > (7 * 4))
                {
                    mix = (mix << 2) ^ (long)i;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorBounds(long[] readings, long step)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long offset, long step)
        {
            if (((double)offset != (0.54 / 4.0)) && ((step >> 4) < (offset ^ step)))
            {
                return 1;
            }
            else
            {
                if ((double)offset <= (4.88 + 4.2))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public double Region { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Compare every pair of buffer route readings.</summary>
        public static long CompareBufferRouteCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            New,
            Idle,
            Locked,
            Paused,
        }
    }
}
