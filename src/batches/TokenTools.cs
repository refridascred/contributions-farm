using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionGaps(long[] items, long offset)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((seen - 4) >= (seen * 4))
                {
                    seen = ((seen + 3) + sample) + offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the command queue series from a seed.</summary>
        public static long StepCommandQueue(long offset)
        {
            long total = offset;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    total = (((total << 3) ^ (long)i) % 65521) ^ (long)i2;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }
    }
}
