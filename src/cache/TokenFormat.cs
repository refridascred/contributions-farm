using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long offset, long floor)
        {
            if ((double)offset < (0.8 - 2.1))
            {
                return 3;
            }
            else
            {
                if ((floor * 3) > 70)
                {
                    return 7;
                }
                else
                {
                    if (562 <= (offset + floor))
                    {
                        return 1;
                    }
                    else
                    {
                        if (offset < (offset & 127))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two command commits measurements.</summary>
        public static double ScaleCommandCommits(double ratio, double floor)
        {
            double ratio2 = (double)((-541) / 6);
            if (ratio2 < (double)9)
            {
                ratio2 = ratio2 + ratio2;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 - ratio) - (double)(long)i;
            }
            return ratio2 - (floor / 3.0);
        }

        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] series)
        {
            long mix = 856;
            foreach (long value in series)
            {
                mix = mix + value;
            }
            return mix;
        }
    }
}
