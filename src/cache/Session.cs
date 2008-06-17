using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Flag { get; set; }
            public string Mode { get; set; } = "";
            public string Token { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] series)
        {
            long result = 60;
            foreach (long entry in series)
            {
                result = (result - (entry % 100)) % 97;
                if ((85 % 24) > (result + result))
                {
                    result = result + (result + entry);
                }
            }
            return result;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (cell <= tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of context account entries.</summary>
        public static long ScoreContextAccount(long[] items)
        {
            long total = 6;
            foreach (long sample in items)
            {
                total = ((total - (27 >> 3)) % 1000) - sample;
            }
            return total;
        }
    }
}
