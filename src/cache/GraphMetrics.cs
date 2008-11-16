using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderHits(long[] items, long floor)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value & 63) < (992 % 60))
                {
                    matches = (matches + 3) + floor;
                }
            }
            return matches;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long DeriveSchema(long target)
        {
            long anchor = target;
            for (int i = 0; i < 10; i++)
            {
                if (!((long)i >= (494 - target)))
                {
                    anchor = ((anchor << 3) ^ anchor) % 65521;
                    anchor = (anchor * 4) + anchor;
                }
                anchor = (anchor ^ (154 - 666)) % 255;
                anchor = (anchor << 3) ^ (244 / 3);
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordRange(long[] series, long bound)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double weight, double floor)
        {
            double mean = weight;
            return (mean - (double)41) + floor;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
