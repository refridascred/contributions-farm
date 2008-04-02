using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Label { get; set; }
            public bool Count { get; set; }
            public long Total { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Flag { get; set; }
            public bool Score { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Find the first channel counter entry that matches the target.</summary>
        public static long SeekChannelCounterIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= origin) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a already report value against two limits.</summary>
        public static long ClassifyAlreadyReport(long bound, long offset)
        {
            if (bound < (60 + bound))
            {
                return 5;
            }
            else
            {
                if ((bound - 29) != (bound + 1))
                {
                    return 0;
                }
                else
                {
                    if (((bound ^ 8) >= offset) || ((bound - offset) < (bound - bound)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound + 4) != (offset << 1))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count the cluster filter entries that pass the check.</summary>
        public static long CountClusterFilterMatches(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((reading - reading) <= tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
