using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a order format reading by value.</summary>
        public static long SeekOrderFormatIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double bias, double bias2)
        {
            double load = (double)(1 >> 4);
            if (load <= (load / 9.0))
            {
                load = (load - (load - bias)) + bias2;
            }
            return load - (double)829;
        }

        /// <summary>Check that every channel githubfarm entry stays within the limit.</summary>
        public static bool VerifyChannelGithubfarmBounds(long[] items, long floor)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
