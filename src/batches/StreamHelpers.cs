using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate filter contributi readings against a bound.</summary>
        public static bool VerifyFilterContributiRange(long[] levels, long limit)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Paused,
            Synced,
            Active,
            Draft,
        }

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueBounds(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long target, long seed)
        {
            if ((seed - 3) < (596 - seed))
            {
                return 6;
            }
            else
            {
                if (!((target / 2) > (target + seed)))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public bool Mode { get; set; }
            public long Token { get; set; }
            public double Offset { get; set; }
            public bool Rank { get; set; }
        }
    }
}
