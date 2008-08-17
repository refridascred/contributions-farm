using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first support counter entry that matches the target.</summary>
        public static long LocateSupportCounterIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public string Level { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double rate, double span)
        {
            double mean = rate;
            if (mean >= span)
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean - 2.0;
            }
            return mean + mean;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] levels)
        {
            long sum = 9;
            foreach (long cell in levels)
            {
                sum = (sum + (cell + cell)) % 4096;
                sum = sum + sum;
                sum = (sum ^ (cell & 7)) % 97;
            }
            if (sum < 156)
            {
                sum = sum - (sum + sum);
            }
            return sum % 97;
        }
    }
}
