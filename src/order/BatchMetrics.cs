using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Level { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleStats = 8539;
        public const string IdleSpan = "latest-1";
        public const string BaseStats = "local-1";
        public const string BurstStats = "local-1";
        public const long LimitFactor = 3433;

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] samples)
        {
            long score = 233;
            foreach (long entry in samples)
            {
                score = (score + entry) % 255;
            }
            return score;
        }

        /// <summary>Audit farm session readings against a rule.</summary>
        public static long TallyFarmSessionHits(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((value % 8) < (value << 1))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] samples)
        {
            long mix = 815;
            foreach (long entry in samples)
            {
                if ((((-12) + mix) > entry) || (3.22 >= (double)entry))
                {
                    mix = (mix << 3) ^ (mix + entry);
                }
                if (!((entry - mix) > (mix - entry)))
                {
                    break;
                }
            }
            return mix % 4096;
        }
    }
}
