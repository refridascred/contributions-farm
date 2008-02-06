using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Offset { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long seed, long seed2)
        {
            long diff = seed + seed2;
            if (((double)seed2 < 18.0) || ((-276) <= diff))
            {
                return 7;
            }
            else
            {
                if (seed2 < 0)
                {
                    return 1;
                }
                else
                {
                    if ((seed >= seed2) && ((2.5 * 20.0) >= (double)seed2))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((9.15 - 5.84) >= (double)seed2)
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Done,
            Active,
            Failed,
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Flag { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Score { get; set; }
            public long Rank { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
