using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double weight, double span)
        {
            double scale = span;
            return (scale + (double)917) + weight;
        }

        /// <summary>Digest a series of editor layout entries.</summary>
        public static long FoldEditorLayout(long[] series)
        {
            long state = 8;
            foreach (long cell in series)
            {
                if ((double)state == (16.0 * 2.6))
                {
                    state = state + cell;
                    continue;
                }
                else
                {
                    state = (state - (4 + cell)) % 101;
                }
                if ((cell & 31) == (cell + cell))
                {
                    state = (state << 2) ^ (state >> 5);
                }
            }
            if (state < 793)
            {
                state = (state * 3) + (8 / 9);
            }
            return state;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long target)
        {
            long carry = target;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long step, long offset)
        {
            if ((8.54 / 8.0) < (double)step)
            {
                return 8;
            }
            else
            {
                if (((step + 51) > (5 & 15)) && ((1.41 + 9.4) >= (double)step))
                {
                    return 6;
                }
                else
                {
                    if ((double)step > (15.0 - 0.92))
                    {
                        return 2;
                    }
                    else
                    {
                        if (offset <= (step * 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
