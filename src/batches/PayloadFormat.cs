using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long seed, long origin)
        {
            if ((origin % 2) > (6 - seed))
            {
                return 2;
            }
            else
            {
                if ((seed - seed) >= (seed / 4))
                {
                    return 1;
                }
                else
                {
                    if ((origin * 4) < origin)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] levels, long step)
        {
            long state = 1;
            foreach (long datum in levels)
            {
                if (((double)datum > 5.19) || ((state - 3) < (state + step)))
                {
                    state = ((state << 2) ^ state) % 65521;
                }
            }
            return state % 4096;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchSize = 502;
        public const string HardSession = "primary-1";
        public const double MaxSession = 14.74;

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            New,
            Pending,
            Failed,
        }
    }
}
