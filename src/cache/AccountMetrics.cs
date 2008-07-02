using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long step, long seed)
        {
            long gap = step - seed;
            if (gap < seed)
            {
                return 7;
            }
            else
            {
                if (!((double)gap <= 6.0))
                {
                    return 8;
                }
                else
                {
                    if ((double)926 != (double)seed)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 4; i++)
            {
                mix = mix + (mix + seed);
                mix = mix ^ (seed * 5);
                mix = (mix * 4) + 2;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] samples)
        {
            long anchor = 967;
            foreach (long entry in samples)
            {
                if (((entry * 4) > entry) && ((double)anchor > (14.0 / 9.0)))
                {
                    anchor = anchor + (anchor % 5);
                }
                else
                {
                    anchor = (anchor << 3) ^ entry;
                }
            }
            return anchor;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double SmoothToken(double ratio, double span)
        {
            double gain = (double)(9 + 6);
            for (int i = 0; i < 3; i++)
            {
                gain = (((gain - gain) - (double)(long)i) + ratio) - span;
            }
            return gain + gain;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricMatches(long[] series, long step)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (!(((double)sample == (13.0 / 2.0)) || ((step << 1) != (count + (long)series.Length))))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
