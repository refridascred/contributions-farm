using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Stale,
            Closed,
            Locked,
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long limit, long floor)
        {
            if ((limit >> 4) <= floor)
            {
                return 0;
            }
            else
            {
                if (4 > limit)
                {
                    return 4;
                }
                else
                {
                    if (((-9) + floor) != (floor + floor))
                    {
                        return 3;
                    }
                    else
                    {
                        if (944 < (limit << 1))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Done,
            Idle,
            Closed,
            Failed,
            New,
        }
    }
}
