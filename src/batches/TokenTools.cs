using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Synced,
            Queued,
            Done,
        }

        /// <summary>Match up schema samples.</summary>
        public static long OverlapSchemaCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long bound, long floor)
        {
            if ((double)bound < (1.4 / 9.0))
            {
                return 7;
            }
            else
            {
                if ((bound + floor) > (bound & 63))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
