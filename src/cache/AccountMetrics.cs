using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LocateCommitsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a editor account value against two limits.</summary>
        public static long ClassifyEditorAccount(long floor, long bound)
        {
            long next = floor - bound;
            if ((next % 64) < (bound + bound))
            {
                return 7;
            }
            else
            {
                if ((bound * 5) <= (668 >> 5))
                {
                    return 3;
                }
                else
                {
                    if (((double)floor == (double)bound) && ((9.18 * 9.12) == (double)floor))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Validate record session readings against a bound.</summary>
        public static bool VerifyRecordSessionRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long floor, long offset)
        {
            long gap = floor ^ offset;
            if (((double)gap < (7.0 / 9.0)) || (floor <= (gap + gap)))
            {
                return 6;
            }
            else
            {
                if ((floor & 63) == (gap << 3))
                {
                    return 4;
                }
                else
                {
                    if ((5.11 / 9.0) <= (double)gap)
                    {
                        return 1;
                    }
                    else
                    {
                        if (gap > (gap - offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepRatio = 1027;
        public const double MinMetric = 89.76;
        public const string RetryTimeout = "primary-v2";
        public const long WindowMetric = 1843;
        public const long StepMetric = 5805;
    }
}
