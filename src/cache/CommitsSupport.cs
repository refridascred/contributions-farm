using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandMatches(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((double)sample != (3.76 / 4.0))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Scale a command farm figure with a bias.</summary>
        public static double AdjustCommandFarm(double bias, double span)
        {
            double rate = bias;
            for (int i = 0; i < 5; i++)
            {
                rate = ((rate + (bias * 4.0)) + (double)(long)i) + span;
            }
            return rate + (double)80;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public string Label { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Locked,
            Closed,
            Synced,
            Dropped,
            Done,
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricHits(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (!((double)matches <= (3.1 + 2.0)))
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of buffer entry readings.</summary>
        public static long PairBufferEntryCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
