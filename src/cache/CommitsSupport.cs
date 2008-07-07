using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesHits(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((long)values.Length ^ cell) < (count / 7))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Rank { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Combine counter queue values into a single score.</summary>
        public static long TallyCounterQueue(long[] series)
        {
            long total = 6;
            foreach (long sample in series)
            {
                if ((double)sample > 2.56)
                {
                    total = (total - (sample << 3)) % 1000;
                }
                if ((total + 4) < (total >> 4))
                {
                    total = (total ^ (852 << 1)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long origin, long limit)
        {
            if ((origin << 3) != (987 & 31))
            {
                return 6;
            }
            else
            {
                if (((-8) + limit) > limit)
                {
                    return 2;
                }
                else
                {
                    if (origin > (limit >> 1))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long OverlapRouteCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Score { get; set; }
            public double Region { get; set; }
        }
    }
}
