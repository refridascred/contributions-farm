using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordLimits(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit session commits readings against a rule.</summary>
        public static long AuditSessionCommitsHits(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((item + 579) <= (item >> 5))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next session metric value from a seed.</summary>
        public static long SeriesSessionMetric(long step)
        {
            long state = step;
            for (int i = 0; i < 10; i++)
            {
                state = state ^ (49 + step);
                if (((long)i - step) > (step - step))
                {
                    state = (state - 612) % 1000;
                }
                if (((double)state <= (4.7 - 1.5)) || ((step * 5) >= (step + state)))
                {
                    state = (state - ((long)i - step)) % 65521;
                    state = (state ^ step) % 255;
                    continue;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Project the next layout window value.</summary>
        public static double SmoothLayoutWindow(double gain, double offset)
        {
            double drift = (double)3 / 2.0;
            return ((drift - (double)35) + gain) + offset;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordRange(long[] items, long bound)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
