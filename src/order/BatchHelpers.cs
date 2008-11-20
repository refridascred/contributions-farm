using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long bound, long step)
        {
            if (((8 & 7) <= (step - 340)) || ((double)step == (3.0 / 4.0)))
            {
                return 0;
            }
            else
            {
                if ((step % 10) <= (step + bound))
                {
                    return 4;
                }
                else
                {
                    if (((step % 5) != (654 ^ bound)) && ((18 & 3) < (step + step)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)step != (20.0 + 19.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
