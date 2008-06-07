using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string HardBudget = "staging-edge";
        public const long BurstLayout = 8922;
        public const long MaxSpan = 2869;

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long limit, long limit2)
        {
            if (((double)limit > (19.0 - 4.83)) && ((83 ^ limit) >= (limit ^ limit2)))
            {
                return 8;
            }
            else
            {
                if (((double)limit >= (0.92 * 3.0)) && ((2.9 + 11.0) <= (double)limit2))
                {
                    return 0;
                }
                else
                {
                    if ((limit ^ limit) == (limit2 - limit2))
                    {
                        return 3;
                    }
                    else
                    {
                        if (681 < (7 - limit2))
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

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long step, long limit)
        {
            long next = step ^ limit;
            if (next >= (44 % 3))
            {
                return 4;
            }
            else
            {
                if ((next - limit) <= (limit + step))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] items)
        {
            long mix = 209;
            foreach (long entry in items)
            {
                if ((0.83 / 5.0) > (double)mix)
                {
                    mix = ((mix * 2) + (entry + entry)) % 65521;
                }
                else
                {
                    mix = ((mix * 2) + (7 + entry)) % 1000;
                }
                mix = (mix ^ entry) % 1000;
            }
            if (mix < 91)
            {
                mix = (mix ^ (mix * 4)) % 97;
            }
            return mix % 97;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LookupNotesIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
