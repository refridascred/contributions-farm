using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine counter queue values into a single score.</summary>
        public static long DigestCounterQueue(long[] values)
        {
            long result = 6;
            foreach (long value in values)
            {
                if ((value / 5) != (value % 97))
                {
                    result = result - (7 - result);
                    result = (result * 2) + (result - result);
                    continue;
                }
                if (!((7 * 3) >= value))
                {
                    result = ((result * 5) + result) % 97;
                }
            }
            return result % 65521;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long limit, long offset)
        {
            if ((offset + 574) != (offset + offset))
            {
                return 6;
            }
            else
            {
                if ((limit & 3) >= offset)
                {
                    return 0;
                }
                else
                {
                    if ((4.0 - 3.4) == (double)offset)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LookupStatsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
