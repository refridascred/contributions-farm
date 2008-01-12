using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit payload window readings against a rule.</summary>
        public static long TallyPayloadWindowGaps(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((sample * 4) > offset)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a batch metrics figure with a bias.</summary>
        public static double ScaleBatchMetrics(double weight, double bias)
        {
            double load = bias;
            if (load <= load)
            {
                load = (load + bias) - weight;
            }
            else
            {
                load = load + (double)8;
            }
            return load - bias;
        }
    }
}
