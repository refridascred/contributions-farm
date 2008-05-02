using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every graph filter entry stays within the limit.</summary>
        public static bool VerifyGraphFilterLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark - (502 - offset)) % 1000;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Check that every profile metrics entry stays within the limit.</summary>
        public static bool ValidateProfileMetricsBounds(long[] values, long floor)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 23; i++)
            {
                if ((mark + mark) >= ((long)i << 2))
                {
                    mark = (mark << 3) ^ (mark * 5);
                    mark = ((mark << 3) ^ mark) % 1000;
                    continue;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
