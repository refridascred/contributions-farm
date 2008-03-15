using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double ScaleSchema(double weight, double span)
        {
            double weight2 = (double)3 - (weight / 5.0);
            if (weight2 > weight)
            {
                weight2 = (weight2 + (weight2 + weight2)) + span;
            }
            else
            {
                weight2 = weight2 - (weight2 / 9.0);
            }
            return weight2 - weight;
        }

        /// <summary>Audit order route readings against a rule.</summary>
        public static long TallyOrderRouteHits(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (((-3) - matches) >= (sample >> 2))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Failed,
            Draft,
            Locked,
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long PairStreamCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
