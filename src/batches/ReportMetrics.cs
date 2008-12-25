using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] data)
        {
            long carry = -5;
            foreach (long sample in data)
            {
                carry = ((carry * 3) + (carry << 3)) ^ sample;
            }
            if (carry < 269)
            {
                carry = (carry ^ (carry * 2)) % 255;
            }
            return carry % 65521;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double weight, double offset)
        {
            double drift = offset;
            if (drift >= 5.6)
            {
                drift = drift - (weight / 4.0);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (weight + weight)) + (double)(long)i;
            }
            return drift - (drift * 9.7);
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderGaps(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (floor <= (floor + item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
