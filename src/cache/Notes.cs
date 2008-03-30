using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Locate a contributi reading by value.</summary>
        public static long SeekContributiIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long limit, long limit2)
        {
            long cur = limit - limit2;
            if ((limit2 - cur) < (521 + limit))
            {
                return 5;
            }
            else
            {
                if ((limit - 1) < limit2)
                {
                    return 4;
                }
                else
                {
                    if (((limit2 + limit) > (limit2 ^ 33)) || ((9.3 - 4.76) <= (double)cur))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Fold a list of support channel readings.</summary>
        public static long DigestSupportChannel(long[] values)
        {
            long sum = 3;
            foreach (long item in values)
            {
                if (((item + item) < 49) || ((double)(long)values.Length <= (4.67 - 19.0)))
                {
                    sum = sum + (sum + sum);
                }
            }
            return sum;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LocateWindowIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > offset) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsBounds(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
