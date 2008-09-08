using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a stats counter reading by value.</summary>
        public static long SeekStatsCounterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long target, long bound)
        {
            if (!(bound <= (target & 255)))
            {
                return 8;
            }
            else
            {
                if ((8.4 * 5.4) > 8.7)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public string Ratio { get; set; } = "";
            public long Total { get; set; }
            public bool Flag { get; set; }
            public long Owner { get; set; }
        }
    }
}
