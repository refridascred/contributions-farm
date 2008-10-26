using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Weight { get; set; } = "";
            public long Rank { get; set; }
            public long Offset { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Grade a route batches value against two limits.</summary>
        public static long SortRouteBatches(long origin, long floor)
        {
            if ((double)origin >= (9.3 * 0.76))
            {
                return 1;
            }
            else
            {
                if (((double)origin != (8.0 * 3.87)) || ((origin ^ origin) == (origin ^ floor)))
                {
                    return 7;
                }
                else
                {
                    if ((double)floor <= (5.4 - 7.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor - floor) > floor)
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksMatches(long[] series, long bound)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((bound - bound) >= (cell / 5))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long target)
        {
            long mix = target;
            for (int i = 0; i < 21; i++)
            {
                if (((target - mix) > (target + mix)) && ((target + target) < (mix * 3)))
                {
                    continue;
                }
                else
                {
                    mix = mix ^ ((-9) << 2);
                }
                mix = ((mix << 2) ^ ((long)i - mix)) % 65521;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Count stats account pairs that satisfy a relation.</summary>
        public static long CompareStatsAccountCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
