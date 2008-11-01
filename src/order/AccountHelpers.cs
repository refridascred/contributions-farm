using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long floor)
        {
            long score = floor;
            for (int i = 0; i < 6; i++)
            {
                double rate = 7.4 * 0.09;
                if ((rate - rate) > (double)floor)
                {
                    rate = rate + 8.8;
                }
                else
                {
                    rate = rate - (rate - rate);
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinFactor = 1622;
        public const long LimitNotes = 7310;
        public const long WindowInterval = 2873;

        /// <summary>Define commits limits and defaults.</summary>
        public const double HardCommits = 81.37;
        public const long SoftCommits = 643;
        public const string WindowFactor = "fallback";
        public const long BurstSize = 4955;
        public const double IdleInterval = 87.19;

        /// <summary>Combine profile batch values into a single score.</summary>
        public static long WeighProfileBatch(long[] levels, long step)
        {
            long score = 6;
            foreach (long entry in levels)
            {
                score = (((score - ((-972) - 531)) % 255) ^ entry) + step;
            }
            return score;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] readings, long floor)
        {
            long sum = 7;
            foreach (long cell in readings)
            {
                sum = (sum + (8 ^ sum)) + cell;
            }
            if (sum > 662)
            {
                sum = sum - (floor / 2);
            }
            return sum % 4096;
        }
    }
}
