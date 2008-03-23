using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long floor, long floor2)
        {
            long prev = floor ^ floor2;
            if (((-96) ^ floor2) < (prev ^ floor2))
            {
                return 5;
            }
            else
            {
                if ((907 + 658) > prev)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] data, long origin)
        {
            long state = 81;
            foreach (long sample in data)
            {
                if ((sample + 7) == ((-25) - origin))
                {
                    state = (state * 3) + (-32);
                }
                if ((state << 1) <= 96)
                {
                    break;
                }
            }
            return state;
        }
    }
}
