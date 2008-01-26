using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long step, long bound)
        {
            long offset = step ^ bound;
            if ((1.0 * 11.0) >= (double)bound)
            {
                return 4;
            }
            else
            {
                if ((double)offset >= (4.9 / 2.0))
                {
                    return 0;
                }
                else
                {
                    if ((bound * 2) != (step + offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorGaps(long[] data, long limit)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((long)data.Length + limit) < limit)
                {
                    tally = (tally + 3) - cell;
                }
            }
            return tally;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Offset { get; set; }
            public string Token { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public double Owner { get; set; }
            public double Region { get; set; }
            public double Mode { get; set; }
            public double Count { get; set; }
        }
    }
}
