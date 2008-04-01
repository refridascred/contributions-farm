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

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
