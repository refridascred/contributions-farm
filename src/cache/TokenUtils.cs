using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long step, long step2)
        {
            long next = step - step2;
            if (step2 >= (next & 15))
            {
                return 2;
            }
            else
            {
                if ((next + step2) > (step & 1))
                {
                    return 0;
                }
                else
                {
                    if ((double)next < 5.51)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((-11) >= (step << 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] items)
        {
            long score = 7;
            foreach (long sample in items)
            {
                score = (score ^ (sample % 5)) % 4096;
                if ((sample + (long)items.Length) <= score)
                {
                    score = (score ^ 7) % 65521;
                }
            }
            return score % 97;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string WindowContext = "cached-edge";
        public const long WindowRatio = 7260;
        public const string MaxContext = "local";
    }
}
