using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstSpan = 9946;
        public const double BaseProfile = 35.68;
        public const long SoftScore = 1479;
        public const long BatchScore = 827;

        /// <summary>Derive the next graph payload value from a seed.</summary>
        public static long SeriesGraphPayload(long target)
        {
            long total = target;
            for (int i = 0; i < 12; i++)
            {
                total = (total << 3) ^ (0 + target);
                total = total + total;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Audit format graph readings against a rule.</summary>
        public static long CountFormatGraphMatches(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((double)matches < (double)matches)
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long FindSessionIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == origin) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Done,
            Dropped,
            Failed,
            Active,
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Locked,
            Queued,
            Failed,
            Done,
        }
    }
}
