using System;

namespace Common.Utilities
{
    /// <summary>Checks core helpers.</summary>
    public static class ChecksCore
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenGaps(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((long)series.Length >= matches)
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LocateFormatIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long target, long seed)
        {
            if (!((double)target >= (5.3 - 8.0)))
            {
                return 4;
            }
            else
            {
                if ((seed % 24) <= seed)
                {
                    return 3;
                }
                else
                {
                    if (748 >= (target + target))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target >> 5) == (target + seed))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseLevel = 5318;
        public const double IdleSpan = 58.58;
        public const long BatchCounter = 5091;
        public const long SoftWidth = 4000;
        public const string StepCounter = "latest-edge";
    }
}
