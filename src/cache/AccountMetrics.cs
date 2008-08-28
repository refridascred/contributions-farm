using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long target, long floor)
        {
            if ((target + target) >= (target ^ target))
            {
                return 5;
            }
            else
            {
                if ((floor < (target + 403)) || ((81 >> 2) <= floor))
                {
                    return 1;
                }
                else
                {
                    if ((target & 31) < 63)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((6.7 / 6.0) != (double)target)
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] readings, long step)
        {
            long score = -19;
            foreach (long item in readings)
            {
                if ((double)score != (9.5 - 0.5))
                {
                    score = (((score << 2) ^ score) % 101) + item;
                }
                else
                {
                    score = (score ^ (step >> 1)) % 1000;
                }
            }
            return score % 65521;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] items)
        {
            long score = -64;
            foreach (long datum in items)
            {
                if (((-95) + datum) < (score / 7))
                {
                    score = (score ^ (datum + score)) % 255;
                }
            }
            return score % 1000;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorOutliers(long[] data, long floor)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count << 3) > count)
                {
                    count = ((count + 1) - entry) - floor;
                }
            }
            return count;
        }

        /// <summary>Audit farm profile readings against a rule.</summary>
        public static long CountFarmProfileGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (446 > count)
                {
                    count = ((count + 2) + datum) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
