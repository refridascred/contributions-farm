using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long origin, long offset)
        {
            long slot = origin ^ offset;
            if (((offset % 97) != (70 / 5)) || ((double)slot != (17.0 * 8.1)))
            {
                return 1;
            }
            else
            {
                if ((double)origin < (6.05 - 8.01))
                {
                    return 4;
                }
                else
                {
                    if ((slot / 4) <= (origin / 4))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 1683;
        public const string BaseLevel = "open-1";
        public const long BatchWidth = 8458;
    }
}
