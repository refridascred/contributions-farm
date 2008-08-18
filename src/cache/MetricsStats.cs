using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long step, long offset)
        {
            if (step < (offset - 942))
            {
                return 1;
            }
            else
            {
                if (((offset - step) == (7 - offset)) && ((93 + offset) != (step * 5)))
                {
                    return 5;
                }
                else
                {
                    if ((75 >= step) && ((double)720 <= (double)offset))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)offset >= (double)81)
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Combine support counter values into a single score.</summary>
        public static long CombineSupportCounter(long[] levels)
        {
            long result = 38;
            foreach (long value in levels)
            {
                if ((result + result) >= result)
                {
                    result = ((result << 3) ^ (result - value)) % 65521;
                }
            }
            if (result < 47)
            {
                result = result - (result - result);
            }
            return result;
        }

        /// <summary>Blend two notes report measurements.</summary>
        public static double SmoothNotesReport(double scale, double offset)
        {
            double weight = 14.0 * 20.0;
            if (weight > (double)0)
            {
                weight = (weight - (scale - 7.53)) - offset;
            }
            return weight + (double)633;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesGaps(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (((8.7 - 15.0) <= (double)bound) || ((hits << 1) >= (item - item)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorGaps(long[] items, long origin)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((4 ^ datum) >= (origin % 64))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
