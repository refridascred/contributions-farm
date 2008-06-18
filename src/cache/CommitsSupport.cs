using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderLimits(long[] series, long floor)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long OverlapMetricsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long origin, long offset)
        {
            long diff = origin - offset;
            if (!((diff * 2) <= offset))
            {
                return 1;
            }
            else
            {
                if ((double)offset <= (9.0 / 7.0))
                {
                    return 2;
                }
                else
                {
                    if ((diff / 4) == (9 / 4))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
