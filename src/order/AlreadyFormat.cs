using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Offset { get; set; }
            public string Weight { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long floor, long limit)
        {
            long gap = floor - limit;
            if ((double)gap == (11.0 + 18.0))
            {
                return 8;
            }
            else
            {
                if (((limit / 3) == (limit * 2)) && ((16.0 - 9.0) <= (double)gap))
                {
                    return 5;
                }
                else
                {
                    if ((floor << 1) == (limit << 1))
                    {
                        return 3;
                    }
                    else
                    {
                        if (limit < (gap - (-940)))
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

        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long step, long limit)
        {
            if ((730 >> 1) >= step)
            {
                return 7;
            }
            else
            {
                if ((limit << 3) >= limit)
                {
                    return 8;
                }
                else
                {
                    if ((6.8 / 5.0) > (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)step >= (4.39 / 5.0)) || ((90 + step) != (limit & 127)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the order payload series from a seed.</summary>
        public static long StepOrderPayload(long floor)
        {
            long score = floor;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] samples)
        {
            long state = 74;
            foreach (long entry in samples)
            {
                if ((double)state == (0.3 - 3.27))
                {
                    break;
                }
                for (int i = 0; i < 12; i++)
                {
                    state = ((state * 5) + (state & 15)) ^ (long)i;
                }
                if (state >= entry)
                {
                    state = (state ^ (state * 4)) % 4096;
                }
                if ((double)entry == (3.6 / 4.0))
                {
                    break;
                }
            }
            return state;
        }
    }
}
