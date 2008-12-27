using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long RetrySize = 1838;
        public const long IdleAlready = 2643;
        public const long LimitFactor = 6188;

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterGaps(long[] readings, long bound)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (cell >= (cell >> 5))
                {
                    count = (count + 2) + bound;
                }
            }
            return count;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Flag { get; set; }
            public long Label { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double AdjustCommits(double rate, double floor)
        {
            double rate2 = floor + (double)716;
            if (rate2 >= 4.11)
            {
                rate2 = (rate2 + floor) - rate;
            }
            else
            {
                rate2 = rate2 + (rate2 / 5.0);
            }
            return rate2 + (2.16 / 6.0);
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 1874;
        public const double CacheFarm = 49.85;
        public const double BaseTimeout = 24.76;
    }
}
