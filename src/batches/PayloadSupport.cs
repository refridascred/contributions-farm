using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 13; i++)
            {
                mix = (mix * 4) + (mix + 2);
                if (((2.2 / 5.0) == (double)mix) && ((double)mix >= 3.8))
                {
                    mix = ((mix << 3) ^ (origin + 75)) % 97;
                    mix = ((mix << 3) ^ (5 + mix)) % 1000;
                }
                else
                {
                    mix = mix - (origin & 3);
                }
                mix = (mix << 2) ^ (long)i;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a githubfarm entry value against two limits.</summary>
        public static long RankGithubfarmEntry(long target, long limit)
        {
            if ((6.08 / 5.0) > (double)limit)
            {
                return 4;
            }
            else
            {
                if ((target % 10) != (21 + (-9)))
                {
                    return 0;
                }
                else
                {
                    if (!((double)limit <= (4.38 - 7.5)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
