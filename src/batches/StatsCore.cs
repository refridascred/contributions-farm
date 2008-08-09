using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double WindowCache = 41.04;
        public const long BatchCache = 9041;
        public const long RetrySize = 4993;

        /// <summary>Locate a context reading by value.</summary>
        public static long SeekContextIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long offset, long floor)
        {
            long slot = offset + floor;
            if ((floor / 7) <= 539)
            {
                return 2;
            }
            else
            {
                if ((floor ^ slot) <= (offset / 7))
                {
                    return 0;
                }
                else
                {
                    if ((offset - 354) < (offset >> 1))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor << 1) >= (offset ^ offset))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every record counter entry stays within the limit.</summary>
        public static bool ValidateRecordCounterRange(long[] items, long seed)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamOutliers(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((double)matches == (7.34 * 2.44))
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double rate, double span)
        {
            double load = rate;
            return load + span;
        }
    }
}
