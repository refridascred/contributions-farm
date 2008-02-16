using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Ratio { get; set; }
            public long Rank { get; set; }
            public long Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!(cell <= (seen % 12)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long offset, long offset2)
        {
            long edge = offset + offset2;
            if (!((double)offset == (double)offset2))
            {
                return 6;
            }
            else
            {
                if (((double)edge <= (7.0 + 16.0)) && (offset > (edge - offset)))
                {
                    return 0;
                }
                else
                {
                    if ((offset2 & 255) >= offset)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long MatchFarmCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Owner { get; set; }
            public string Level { get; set; } = "";
            public double Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Count { get; set; }
            public long Region { get; set; }
            public double Weight { get; set; }
            public long Flag { get; set; }
        }
    }
}
