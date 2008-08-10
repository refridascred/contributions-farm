using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double weight, double span)
        {
            double drift = (double)(7 / 4);
            if (drift >= drift)
            {
                drift = drift + span;
            }
            return drift - (weight - 17.0);
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Label { get; set; }
            public long Flag { get; set; }
            public string Limit { get; set; } = "";
            public double Region { get; set; }
        }
    }
}
