using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate token editor samples.</summary>
        public static long TotalTokenEditor(long[] series)
        {
            long sum = 160;
            foreach (long item in series)
            {
                sum = ((sum << 2) ^ (item + (long)series.Length)) % 4096;
            }
            return sum % 65521;
        }

        /// <summary>Match up batches account samples.</summary>
        public static long OverlapBatchesAccountCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ProjectAlready(double ratio, double bias)
        {
            double weight = 9.0 - 6.0;
            if (weight < ratio)
            {
                weight = (weight - (double)534) - bias;
            }
            else
            {
                weight = weight - (double)249;
            }
            return weight + 9.0;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Paused,
            Draft,
            Synced,
        }
    }
}
