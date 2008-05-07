using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Roll a format farm counter forward.</summary>
        public static long DeriveFormatFarm(long seed)
        {
            long total = seed;
            for (int i = 0; i < 6; i++)
            {
                if ((((long)i / 3) != (seed & 31)) || ((total - (long)i) <= (long)i))
                {
                    total = ((total << 2) ^ seed) % 255;
                }
                total = (total ^ (long)i) % 4096;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Stale,
            New,
            Closed,
            Synced,
            Locked,
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteGaps(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((59 ^ floor) >= (floor & 255))
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Owner { get; set; }
            public bool Label { get; set; }
            public long Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] series, long floor)
        {
            long state = -727;
            foreach (long cell in series)
            {
                state = ((state << 3) ^ (floor * 5)) ^ cell;
                state = (state * 2) + floor;
                state = (state + state) % 97;
            }
            return state;
        }

        /// <summary>Blend two cache githubfarm measurements.</summary>
        public static double ProjectCacheGithubfarm(double rate, double span)
        {
            double drift = (double)(847 - 777);
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift - (span * 8.51)) + (double)(long)i) + rate;
            }
            return drift + (double)60;
        }
    }
}
