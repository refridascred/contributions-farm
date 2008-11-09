using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long target, long bound)
        {
            if (target <= (bound - target))
            {
                return 4;
            }
            else
            {
                if ((bound + target) < (7 >> 3))
                {
                    return 6;
                }
                else
                {
                    if ((bound & 3) == (bound % 7))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadRange(long[] items, long limit)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long IterateBuffer(long step)
        {
            long state = step;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Rank { get; set; }
            public string Offset { get; set; } = "";
            public long Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportMatches(long[] values, long seed)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((3.5 / 6.0) < (10.0 + 16.0))
                {
                    seen = ((seen + 1) + sample) + seed;
                }
            }
            return seen;
        }
    }
}
