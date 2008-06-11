using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= seed) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up layout record samples.</summary>
        public static long MatchLayoutRecordCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Failed,
            Idle,
            Closed,
            New,
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long offset, long offset2)
        {
            long prev = offset + offset2;
            if (!(offset2 > (prev + offset)))
            {
                return 0;
            }
            else
            {
                if ((offset % 24) < offset)
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
}
