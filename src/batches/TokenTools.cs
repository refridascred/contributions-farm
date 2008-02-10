using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a format commits pair into a bucket.</summary>
        public static long GradeFormatCommits(long seed, long origin)
        {
            long cur = seed ^ origin;
            if (((seed / 6) < (origin ^ origin)) || ((seed + origin) == (cur << 1)))
            {
                return 5;
            }
            else
            {
                if ((cur + cur) > (4 / 2))
                {
                    return 2;
                }
                else
                {
                    if ((origin >> 4) == (origin >> 1))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin <= cur) && (288 < (seed * 3)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferRange(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
