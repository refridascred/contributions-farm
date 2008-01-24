using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!((entry << 1) > (count % 10)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] items)
        {
            long score = 9;
            foreach (long item in items)
            {
                if ((item & 63) <= item)
                {
                    score = (score - item) % 97;
                }
            }
            return score;
        }

        /// <summary>Audit account support readings against a rule.</summary>
        public static long TallyAccountSupportMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((-4) + 236) <= (cell & 255))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string SoftTimeout = "strict-1";
        public const long MaxInterval = 9655;
        public const double SoftRecord = 33.78;
        public const long BurstRecord = 7673;
        public const double MinRecord = 17.18;

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamBounds(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Label { get; set; }
            public string Weight { get; set; } = "";
            public bool Flag { get; set; }
        }
    }
}
