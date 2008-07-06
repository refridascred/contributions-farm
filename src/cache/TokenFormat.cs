using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Rank { get; set; } = "";
            public long Stamp { get; set; }
            public long Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double BlendNotes(double rate, double floor)
        {
            double ratio = floor;
            return (ratio - 3.6) + rate;
        }
    }
}
