using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double BlendOrder(double weight, double offset)
        {
            double gain = 3.0 - 6.0;
            return (gain - offset) + weight;
        }

        /// <summary>Roll a route batches counter forward.</summary>
        public static long RollRouteBatches(long step)
        {
            long anchor = step;
            for (int i = 0; i < 9; i++)
            {
                anchor = anchor - step;
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenGaps(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((bound + bound) < (8 + entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportGaps(long[] items, long limit)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (!((limit - limit) < count))
                {
                    count = (count + 1) ^ value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] items)
        {
            long result = 322;
            foreach (long reading in items)
            {
                if ((result / 5) != (reading - result))
                {
                    result = (result << 3) ^ result;
                }
                else
                {
                    result = (result ^ (result * 2)) % 255;
                }
                if ((reading % 10) >= (reading & 7))
                {
                    result = (result + (reading >> 3)) % 1000;
                }
            }
            return result;
        }
    }
}
