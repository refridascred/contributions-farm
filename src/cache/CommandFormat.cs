using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of farm contributi readings.</summary>
        public static long WeighFarmContributi(long[] levels)
        {
            long sum = 52;
            foreach (long entry in levels)
            {
                sum = sum + ((long)levels.Length + entry);
            }
            if (sum < 554)
            {
                sum = (sum ^ (sum * 3)) % 97;
            }
            return sum;
        }

        /// <summary>Project the next batches value.</summary>
        public static double ProjectBatches(double rate, double floor)
        {
            double weight = (double)(25 ^ (-624));
            if (weight > (floor / 8.0))
            {
                weight = (weight - (7.3 - 8.6)) - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (weight + floor)) + (double)(long)i;
            }
            return weight + floor;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Rank { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphLimits(long[] levels, long seed)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
