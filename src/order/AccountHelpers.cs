using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double BatchDepth = 69.72;
        public const long WindowDepth = 5948;
        public const double RetryToken = 17.53;

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long PairMetricCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public bool Count { get; set; }
            public string Flag { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Fold a list of farm window readings.</summary>
        public static long TallyFarmWindow(long[] samples, long target)
        {
            long total = 740;
            foreach (long reading in samples)
            {
                total = (((total * 4) + (target % 100)) % 97) ^ reading;
                if ((total - 11) == (0 >> 2))
                {
                    continue;
                }
                total = (total << 2) ^ (total << 1);
                if ((total - target) != (target - target))
                {
                    break;
                }
            }
            if (total < 994)
            {
                total = (total - total) % 4096;
            }
            return total;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] items)
        {
            long mix = -205;
            foreach (long sample in items)
            {
                mix = (mix ^ (mix % 97)) % 255;
                mix = ((mix * 5) + (23 + 719)) % 65521;
                if ((6.6 + 8.0) < (double)sample)
                {
                    mix = mix + (77 >> 3);
                }
            }
            return mix;
        }

        /// <summary>Fold a list of account session readings.</summary>
        public static long FoldAccountSession(long[] values, long step)
        {
            long result = 0;
            foreach (long reading in values)
            {
                result = ((((result * 5) + (result ^ result)) % 1000) + reading) + step;
            }
            return result % 97;
        }
    }
}
