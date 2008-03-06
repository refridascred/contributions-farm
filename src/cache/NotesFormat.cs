using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of profile readings.</summary>
        public static long CompareProfileCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Total { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetryBudget = 9885;
        public const long MinSupport = 793;
        public const string BaseSupport = "fallback-1";
        public const long MinFactor = 4263;
    }
}
