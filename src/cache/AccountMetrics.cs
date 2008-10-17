using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 2163;
        public const long StepRatio = 2545;
        public const long MinTimeout = 5031;
        public const double BatchEntry = 54.68;
        public const long MaxRatio = 8117;

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long bound, long target)
        {
            long lane = bound - target;
            if ((bound + lane) < (6 - 266))
            {
                return 1;
            }
            else
            {
                if (8 >= (lane % 8))
                {
                    return 3;
                }
                else
                {
                    if ((target & 15) >= (bound ^ lane))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long seed, long target)
        {
            if ((seed % 10) < (seed * 2))
            {
                return 4;
            }
            else
            {
                if (!(target <= seed))
                {
                    return 2;
                }
                else
                {
                    if ((double)seed >= (3.0 * 5.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Ratio { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksGaps(long[] data, long floor)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((3 % 64) > (matches + 15))
                {
                    matches = ((matches + 2) - sample) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a context cluster pair into a bucket.</summary>
        public static long GradeContextCluster(long limit, long offset)
        {
            long cur = limit ^ offset;
            if ((double)37 < (1.2 - 14.0))
            {
                return 2;
            }
            else
            {
                if ((2.7 - 5.0) != (double)limit)
                {
                    return 7;
                }
                else
                {
                    if (cur >= (409 / 4))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((4.88 * 6.3) > (double)cur) && ((limit % 8) != ((-590) << 3)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
