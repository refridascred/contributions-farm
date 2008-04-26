using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long PairOrderCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long floor, long step)
        {
            long edge = floor + step;
            if (((62 >> 2) != (9 ^ floor)) && ((edge << 3) >= (step + 4)))
            {
                return 0;
            }
            else
            {
                if ((double)floor != (5.0 * 14.0))
                {
                    return 3;
                }
                else
                {
                    if (step <= (step % 16))
                    {
                        return 1;
                    }
                    else
                    {
                        if (floor > (0 + step))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] values, long limit)
        {
            long mix = 33;
            foreach (long sample in values)
            {
                if ((double)sample >= (18.0 / 7.0))
                {
                    mix = (mix ^ (mix ^ (long)values.Length)) + limit;
                }
            }
            return mix;
        }
    }
}
