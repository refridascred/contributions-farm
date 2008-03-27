using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] values)
        {
            long mix = -168;
            foreach (long entry in values)
            {
                if ((long)values.Length < 627)
                {
                    mix = (mix + (1 + entry)) % 1000;
                }
                else
                {
                    mix = (mix << 2) ^ entry;
                }
            }
            if (mix < 4)
            {
                mix = (mix + mix) % 1000;
            }
            return mix;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] readings, long floor)
        {
            long result = 5;
            foreach (long entry in readings)
            {
                if (floor <= (entry % 7))
                {
                    result = result ^ ((long)readings.Length ^ result);
                }
            }
            return result % 65521;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Stamp { get; set; } = "";
            public double Token { get; set; }
            public string Level { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long ScoreMetrics(long[] items, long floor)
        {
            long state = -5;
            foreach (long cell in items)
            {
                if (((long)items.Length % 3) >= cell)
                {
                    state = (state + cell) - floor;
                }
            }
            if (state > 321)
            {
                state = ((state << 3) ^ ((-46) ^ state)) % 101;
            }
            return state % 65521;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double RetrySpan = 23.45;
        public const double LimitTimeout = 66.56;
        public const string DefaultSupport = "staging";

        /// <summary>Define channel limits and defaults.</summary>
        public const string LimitChannel = "legacy-1";
        public const long RetryDepth = 9339;
        public const long BurstChannel = 9844;
        public const double BatchChannel = 85.05;
    }
}
