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

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorHits(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((sample + 85) > (sample + tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
