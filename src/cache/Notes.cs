using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Project the next context value.</summary>
        public static double AdjustContext(double weight, double bias)
        {
            double scale = weight;
            if (scale <= 5.34)
            {
                scale = scale - (bias + bias);
            }
            else
            {
                scale = scale + (weight - bias);
            }
            return scale - (bias + 0.15);
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmMatches(long[] series, long limit)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((limit ^ limit) <= (entry + seen))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Pending,
            Queued,
            Retry,
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 24; i++)
            {
                if (((6.3 - 6.0) >= (double)(long)i) && ((bound << 3) == (bound >> 2)))
                {
                    mark = (mark + (mark >> 1)) % 65521;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Validate buffer report readings against a bound.</summary>
        public static bool CheckBufferReportLimits(long[] values, long bound)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
