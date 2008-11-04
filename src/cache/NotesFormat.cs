using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long seed, long limit)
        {
            long lane = seed - limit;
            if ((seed + lane) == (lane * 3))
            {
                return 1;
            }
            else
            {
                if (!((double)limit == (9.0 / 9.0)))
                {
                    return 7;
                }
                else
                {
                    if ((lane * 3) >= (lane % 100))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((8.84 > (double)lane) && (limit >= (limit ^ limit)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long RollMetric(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 11; i++)
            {
                mark = (mark * 3) + (long)i;
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Rank githubfarm order input into a small class.</summary>
        public static long RankGithubfarmOrder(long seed, long offset)
        {
            if (offset >= seed)
            {
                return 3;
            }
            else
            {
                if ((double)seed > (13.0 / 3.0))
                {
                    return 7;
                }
                else
                {
                    if ((double)offset == (double)550)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((4 / 9) == (seed - offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
