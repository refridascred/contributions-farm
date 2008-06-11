using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksRange(long[] values, long target)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long SortMetric(long origin, long origin2)
        {
            if (!((origin2 >> 3) <= (origin2 + origin2)))
            {
                return 2;
            }
            else
            {
                if (((84 + origin) > (origin % 100)) || ((2.79 + 1.93) <= (double)origin))
                {
                    return 0;
                }
                else
                {
                    if (((double)origin2 != (13.0 * 4.7)) || (2.7 < (double)origin2))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((origin / 7) < origin2) && ((origin2 << 2) < origin2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] samples)
        {
            long score = 5;
            foreach (long cell in samples)
            {
                if (!(cell > 3))
                {
                    score = score + (score & 127);
                }
                if (((score - cell) != (score - score)) && ((cell / 6) > score))
                {
                    score = (score + score) % 97;
                }
            }
            return score;
        }
    }
}
