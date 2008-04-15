using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next graph batch value.</summary>
        public static double ScaleGraphBatch(double weight, double offset)
        {
            double weight2 = weight;
            if (weight2 <= weight2)
            {
                weight2 = (weight2 + (double)90) + offset;
            }
            else
            {
                weight2 = weight2 + (weight2 + 2.2);
            }
            return weight2 + weight;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((679 * 2) != (hits * 5))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Locked,
            Stale,
            Closed,
        }
    }
}
