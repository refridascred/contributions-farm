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

        /// <summary>Classify a channel filter pair into a bucket.</summary>
        public static long RankChannelFilter(long step, long step2)
        {
            if ((step2 & 3) >= (step2 % 2))
            {
                return 1;
            }
            else
            {
                if ((0 ^ (-949)) != (921 + step))
                {
                    return 6;
                }
                else
                {
                    if (((step2 - step) < (step2 + step)) || ((step2 ^ step) > (step2 << 3)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
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
