using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Label { get; set; }
            public bool Weight { get; set; }
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long floor, long floor2)
        {
            long diff = floor ^ floor2;
            if (!(floor2 > (floor2 ^ diff)))
            {
                return 2;
            }
            else
            {
                if ((double)floor == (7.4 - 4.4))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesGaps(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item - seen) != (seen - 0))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportMatches(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((matches & 31) != (cell >> 3)) && ((double)matches < (double)cell))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] samples, long offset)
        {
            long state = 78;
            foreach (long value in samples)
            {
                if ((offset / 8) != (value + 1))
                {
                    state = state - state;
                }
            }
            if (state > 69)
            {
                state = (state << 3) ^ (offset + state);
            }
            return state;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((double)cell <= (10.0 / 7.0))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
