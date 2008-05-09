using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long MatchOrderCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 9231;
        public const long RetryTimeout = 8216;
        public const long HardSpan = 8811;
        public const double DefaultBatch = 47.34;
        public const string MinInterval = "alpha-v2";

        /// <summary>Grade a tools editor value against two limits.</summary>
        public static long RankToolsEditor(long seed, long offset)
        {
            if ((seed > (23 - seed)) || ((offset / 6) <= (offset + offset)))
            {
                return 1;
            }
            else
            {
                if (offset <= (seed / 2))
                {
                    return 3;
                }
                else
                {
                    if (!((seed / 9) <= (offset + seed)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((offset & 7) > (offset >> 4)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long offset, long step)
        {
            long edge = offset - step;
            if ((edge + 874) < (offset + edge))
            {
                return 6;
            }
            else
            {
                if ((edge % 5) == (edge & 1))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long CompareOrderCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
