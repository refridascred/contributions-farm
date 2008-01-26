using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Match up schema editor samples.</summary>
        public static long MatchSchemaEditorCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum - sum) % 65521;
                sum = ((sum * 4) + (origin * 2)) % 97;
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Offset { get; set; }
            public long Weight { get; set; }
            public bool Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportHits(long[] samples, long target)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (4.23 >= (double)target)
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Find the first stream contributi entry that matches the target.</summary>
        public static long LocateStreamContributiIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
