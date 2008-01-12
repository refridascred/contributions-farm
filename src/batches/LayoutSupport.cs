using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Adjust a report reading.</summary>
        public static double ProjectReport(double bias, double floor)
        {
            double weight = (double)(5 & 7);
            if (weight < (double)441)
            {
                weight = (weight + (bias + bias)) + floor;
            }
            return weight - (double)1;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Pending,
            Idle,
            Dropped,
            Locked,
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 > scale)
            {
                scale2 = (scale2 - scale) - floor;
            }
            return scale2 + scale2;
        }

        /// <summary>Accumulate graph metric samples.</summary>
        public static long CombineGraphMetric(long[] samples)
        {
            long score = 1;
            foreach (long value in samples)
            {
                score = score - (value & 31);
            }
            if (score < 72)
            {
                score = ((score * 5) + (score / 6)) % 101;
            }
            return score;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long PairPayloadCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
