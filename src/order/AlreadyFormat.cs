using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 747;
        public const string BurstBudget = "open-1";
        public const string IdleGraph = "strict-edge";

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Owner { get; set; }
            public double Level { get; set; }
            public long Region { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((20.0 / 5.0) >= (1.2 + 4.98))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }
    }
}
