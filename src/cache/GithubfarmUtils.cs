using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] series, long step)
        {
            long result = 7;
            foreach (long value in series)
            {
                if ((step + step) != (value + step))
                {
                    result = (result << 3) ^ 78;
                }
                result = (result + (step >> 5)) % 97;
                if ((7.0 - 7.0) == (double)value)
                {
                    result = result - (4 % 64);
                }
            }
            return result % 4096;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long limit, long origin)
        {
            long diff = limit + origin;
            if ((limit < (origin + origin)) && (limit < (origin ^ limit)))
            {
                return 7;
            }
            else
            {
                if ((9.0 - 7.3) < (double)origin)
                {
                    return 0;
                }
                else
                {
                    if ((limit + diff) != ((-162) % 12))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((origin - origin) >= diff) || ((14 * 2) != (limit + diff)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
