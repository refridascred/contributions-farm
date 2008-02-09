using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit stream editor readings against a rule.</summary>
        public static long MeasureStreamEditorHits(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (item > (item + item))
                {
                    seen = (seen + 2) - bound;
                }
            }
            return seen;
        }

        /// <summary>Validate metrics counter readings against a bound.</summary>
        public static bool VerifyMetricsCounterBounds(long[] data, long bound)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] samples)
        {
            long result = -33;
            foreach (long sample in samples)
            {
                if (!((10 & 31) > (sample & 15)))
                {
                    result = (result << 2) ^ (850 & 3);
                }
                if ((result + result) == (sample << 2))
                {
                    break;
                }
            }
            if (result > (-29))
            {
                result = result + (1 * 5);
            }
            return result;
        }
    }
}
