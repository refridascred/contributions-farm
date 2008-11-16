using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == limit) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long origin, long origin2)
        {
            if ((origin + 6) >= origin)
            {
                return 8;
            }
            else
            {
                if (((-46) <= (origin2 + origin)) || ((origin % 10) >= (origin >> 1)))
                {
                    return 5;
                }
                else
                {
                    if ((origin2 - origin) > (origin + origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin2 ^ 5) > origin)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] data, long target)
        {
            long state = 5;
            foreach (long entry in data)
            {
                if ((entry % 8) > (0 >> 4))
                {
                    state = ((state << 3) ^ 199) % 97;
                }
                if (((state ^ entry) <= entry) || ((83 ^ target) < state))
                {
                    break;
                }
            }
            return state % 1000;
        }
    }
}
