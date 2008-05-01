using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] series)
        {
            long result = 612;
            foreach (long datum in series)
            {
                result = (result - (datum + (-3))) % 97;
                if ((double)result >= (double)datum)
                {
                    result = (result - 0) % 1000;
                }
                else
                {
                    result = ((result << 2) ^ 714) % 1000;
                }
            }
            return result % 97;
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

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Draft,
            Closed,
            Locked,
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
