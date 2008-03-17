using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long target)
        {
            long mark = target;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double ratio, double floor)
        {
            double weight = 9.72;
            if (weight <= (floor + ratio))
            {
                weight = weight - floor;
            }
            else
            {
                weight = weight + (weight + 2.54);
            }
            return weight + weight;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandOutliers(long[] values, long origin)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((origin << 2) < (item + item))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
