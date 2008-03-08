using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count cluster account pairs that satisfy a relation.</summary>
        public static long MatchClusterAccountCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderGaps(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((seed - 944) < (982 >> 5))
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Iterate the editor contributi series from a seed.</summary>
        public static long SeriesEditorContributi(long target)
        {
            long acc = target;
            for (int i = 0; i < 4; i++)
            {
                acc = acc - ((long)i & 31);
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Grade a tools editor value against two limits.</summary>
        public static long RankToolsEditor(long limit, long seed)
        {
            long prev = limit ^ seed;
            if ((prev / 7) >= prev)
            {
                return 7;
            }
            else
            {
                if ((double)seed != (double)7)
                {
                    return 4;
                }
                else
                {
                    if ((seed & 127) <= (seed ^ limit))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)limit < (19.0 * 20.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
