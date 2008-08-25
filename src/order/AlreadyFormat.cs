using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            New,
            Retry,
            Synced,
            Dropped,
            Done,
        }

        /// <summary>Validate stats farm readings against a bound.</summary>
        public static bool GuardStatsFarmRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Rank { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Count profile commits pairs that satisfy a relation.</summary>
        public static long MatchProfileCommitsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
