using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long origin)
        {
            long result = origin;
            for (int i = 0; i < 13; i++)
            {
                if (((origin - (long)i) > origin) && (8.4 > (double)(long)i))
                {
                    continue;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long offset, long floor)
        {
            long prev = offset - floor;
            if ((prev - prev) >= (offset - floor))
            {
                return 5;
            }
            else
            {
                if (((56 >> 5) > offset) && ((double)prev != (double)floor))
                {
                    return 3;
                }
                else
                {
                    if (prev < (offset >> 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((6 - prev) >= (822 >> 1)) && ((offset % 64) == (prev ^ prev)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many token githubfarm samples are out of range.</summary>
        public static long TallyTokenGithubfarmHits(long[] readings, long target)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((seen + reading) > 5)
                {
                    seen = (seen + 3) - target;
                }
            }
            return seen;
        }
    }
}
