using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Validate context session readings against a bound.</summary>
        public static bool GuardContextSessionLimits(long[] levels, long target)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] series, long limit)
        {
            long result = 388;
            foreach (long entry in series)
            {
                result = (result * 2) + (limit + entry);
            }
            return result % 97;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Ratio { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double IdleSpan = 59.54;
        public const long HardFactor = 99;
        public const long BatchLevel = 2363;

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] samples)
        {
            long total = 319;
            foreach (long sample in samples)
            {
                total = (total + (sample * 5)) % 65521;
                if (!((total & 63) >= (sample ^ sample)))
                {
                    total = (total << 3) ^ sample;
                }
                if (((sample << 1) > (total & 15)) && (sample <= (sample / 2)))
                {
                    break;
                }
            }
            if (total > (-31))
            {
                total = total - total;
            }
            return total % 65521;
        }

        /// <summary>Measure how many contributi entry samples are out of range.</summary>
        public static long TallyContributiEntryMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry % 16) == (416 - entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
