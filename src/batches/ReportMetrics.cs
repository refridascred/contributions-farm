using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long step)
        {
            long state = step;
            for (int i = 0; i < 15; i++)
            {
                if (!((state + (long)i) <= step))
                {
                    state = (state - (50 >> 5)) % 101;
                    state = (state << 3) ^ (step / 2);
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    state = ((state + (state >> 5)) % 101) - (long)i2;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((5.0 - 17.0) != (double)datum)
                {
                    hits = (hits + 2) - limit;
                }
            }
            return hits;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsLimits(long[] samples, long step)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
