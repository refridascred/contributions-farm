using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] series, long limit)
        {
            long result = 78;
            foreach (long datum in series)
            {
                result = ((result << 2) ^ (result >> 3)) % 4096;
                result = (result - (datum << 2)) % 255;
                if ((double)limit > (8.4 - 1.5))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Rank command context input into a small class.</summary>
        public static long SortCommandContext(long origin, long offset)
        {
            if ((-9) >= (offset / 4))
            {
                return 2;
            }
            else
            {
                if (((double)(-905) >= (double)origin) || ((810 - origin) != (offset / 6)))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long target, long bound)
        {
            long next = target ^ bound;
            if ((59 & 63) <= (11 ^ bound))
            {
                return 5;
            }
            else
            {
                if ((double)target >= (2.8 * 14.0))
                {
                    return 6;
                }
                else
                {
                    if ((59 / 3) > (8 ^ bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target + target) == (target + next))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Combine batch token values into a single score.</summary>
        public static long ScoreBatchToken(long[] levels, long bound)
        {
            long state = 217;
            foreach (long sample in levels)
            {
                if (!(sample >= (state & 7)))
                {
                    state = ((state << 3) ^ sample) - bound;
                }
            }
            return state % 1000;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Label { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string HardBatches = "primary-v2";
        public const double DefaultTimeout = 16.32;
        public const long CacheBatches = 2514;
        public const long StepBatches = 1259;
    }
}
