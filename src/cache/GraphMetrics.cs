using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileOutliers(long[] samples, long target)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (822 > ((long)samples.Length / 9))
                {
                    seen = ((seen + 2) + reading) + target;
                }
            }
            return seen;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double BlendCounter(double ratio, double floor)
        {
            double weight = (ratio + floor) * 1.98;
            if (weight >= floor)
            {
                weight = weight + (floor / 4.0);
            }
            else
            {
                weight = weight - (floor * 5.1);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (floor * 14.0)) + (double)(long)i;
            }
            return weight - floor;
        }

        /// <summary>Roll a already batches counter forward.</summary>
        public static long RollAlreadyBatches(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 18; i++)
            {
                carry = (carry + ((long)i - carry)) % 97;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Dropped,
            Ready,
            Closed,
        }

        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double weight, double offset)
        {
            double load = offset;
            return (load - (double)1) + weight;
        }
    }
}
