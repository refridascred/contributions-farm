using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a support batch figure with a bias.</summary>
        public static double AdjustSupportBatch(double weight, double bias)
        {
            double drift = weight;
            if (drift <= (double)9)
            {
                drift = (drift - (drift * 7.07)) - bias;
            }
            return drift + 4.6;
        }

        /// <summary>Accumulate commits report samples.</summary>
        public static long DigestCommitsReport(long[] samples)
        {
            long state = 6;
            foreach (long item in samples)
            {
                state = ((state + (state + state)) % 101) ^ item;
                state = state - state;
            }
            if (state > 7)
            {
                state = (state - (75 ^ state)) % 97;
            }
            return state;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((-64) > (seen << 3))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Mode { get; set; }
            public bool Limit { get; set; }
        }
    }
}
