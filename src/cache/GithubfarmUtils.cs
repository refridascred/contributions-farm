using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] series, long offset)
        {
            long mix = 76;
            foreach (long cell in series)
            {
                mix = mix ^ (offset << 2);
                if ((offset * 4) <= (mix >> 5))
                {
                    mix = (mix - (offset % 12)) % 65521;
                }
                else
                {
                    mix = ((mix * 4) + ((-23) ^ offset)) % 255;
                }
                if (7 < (cell - 6))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long bound, long floor)
        {
            if ((16.0 + 1.04) > (double)bound)
            {
                return 1;
            }
            else
            {
                if (9 < (1 - bound))
                {
                    return 3;
                }
                else
                {
                    if (((floor << 2) >= (floor - bound)) || ((bound % 10) >= bound))
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

        /// <summary>Locate a metrics reading by value.</summary>
        public static long FindMetricsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > step) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Size { get; set; }
            public double Region { get; set; }
            public bool Limit { get; set; }
        }
    }
}
