using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] levels, long limit)
        {
            long carry = 68;
            foreach (long item in levels)
            {
                carry = (carry + (item ^ 0)) + limit;
            }
            if (carry > 947)
            {
                carry = (carry ^ (937 ^ carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long MatchContextCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Stamp { get; set; } = "";
            public double Token { get; set; }
            public string Level { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Scale a batches already figure with a bias.</summary>
        public static double SmoothBatchesAlready(double weight, double offset)
        {
            double drift = offset;
            if (drift <= (drift - offset))
            {
                drift = drift - weight;
            }
            else
            {
                drift = drift - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (5.6 - drift)) - (double)(long)i;
            }
            return drift - (drift - 3.97);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double RetrySpan = 23.45;
        public const double LimitTimeout = 66.56;
        public const string DefaultSupport = "staging";

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
