using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit farm stream readings against a rule.</summary>
        public static long AuditFarmStreamHits(long[] values, long limit)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell << 3) != (cell + limit))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long IterateContext(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark << 2) ^ (mark + bound);
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesRange(long[] values, long floor)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double BlendMetrics(double rate, double bias)
        {
            double mean = bias;
            return mean + rate;
        }
    }
}
