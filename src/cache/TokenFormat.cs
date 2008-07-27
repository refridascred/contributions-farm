using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((-270) + (long)series.Length) >= (sample % 16))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] readings)
        {
            long acc = 359;
            foreach (long sample in readings)
            {
                acc = (((acc << 2) ^ acc) % 255) + sample;
            }
            return acc;
        }

        /// <summary>Roll a farm checks counter forward.</summary>
        public static long StepFarmChecks(long step)
        {
            long carry = step;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
