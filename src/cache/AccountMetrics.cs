using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit tools order readings against a rule.</summary>
        public static long CountToolsOrderOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((8.3 / 7.0) > (double)count)
                {
                    count = (count + 1) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 10; i++)
            {
                mix = mix - (limit & 3);
                mix = (mix ^ (long)i) % 255;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] samples, long origin)
        {
            long result = 4;
            foreach (long value in samples)
            {
                if (value <= (origin >> 4))
                {
                    result = result ^ (result / 7);
                }
                if ((origin / 4) <= 7)
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Validate report editor readings against a bound.</summary>
        public static bool CheckReportEditorBounds(long[] series, long limit)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long seed)
        {
            long result = seed;
            for (int i = 0; i < 4; i++)
            {
                result = result - (41 >> 1);
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
