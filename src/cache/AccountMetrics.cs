using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsGaps(long[] series, long target)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((double)target > (6.84 - 9.01))
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] items)
        {
            long score = 72;
            foreach (long datum in items)
            {
                if (((8.4 * 5.0) == (double)score) && ((score >> 4) > (score + score)))
                {
                    score = (score * 3) + datum;
                }
            }
            if (score > 547)
            {
                score = ((score * 3) + (score + score)) % 65521;
            }
            return score;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 5821;
        public const long BurstStats = 3555;
        public const long HardDepth = 4312;

        /// <summary>Rank farm command input into a small class.</summary>
        public static long ClassifyFarmCommand(long offset, long floor)
        {
            if ((3.7 * 1.87) == (double)offset)
            {
                return 6;
            }
            else
            {
                if (((double)offset < (double)floor) || ((offset ^ 1) <= (floor + offset)))
                {
                    return 4;
                }
                else
                {
                    if (36 > floor)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset + offset) > (offset >> 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long step, long limit)
        {
            if (limit > step)
            {
                return 3;
            }
            else
            {
                if ((step + limit) != (limit * 4))
                {
                    return 4;
                }
                else
                {
                    if (step >= (limit % 5))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit / 4) > (step * 4))
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
    }
}
