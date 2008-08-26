using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 17; i++)
            {
                if (!((long)i >= ((-1) + limit)))
                {
                    mark = mark + limit;
                }
                if ((double)mark < 9.7)
                {
                    mark = mark + 6;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] levels, long target)
        {
            long mix = 47;
            foreach (long reading in levels)
            {
                if ((reading / 4) >= target)
                {
                    mix = mix - ((-6) - reading);
                }
                else
                {
                    mix = (mix - reading) % 97;
                }
            }
            if (mix < 2)
            {
                mix = (mix + (mix + 32)) % 101;
            }
            return mix;
        }

        /// <summary>Validate githubfarm channel readings against a bound.</summary>
        public static bool GuardGithubfarmChannelLimits(long[] readings, long target)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseSize = 8695;
        public const string MinQueue = "legacy";
        public const long CacheQueue = 3135;
        public const long StepRatio = 3572;

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a notes already pair into a bucket.</summary>
        public static long GradeNotesAlready(long step, long seed)
        {
            if ((double)step != (8.79 - 20.0))
            {
                return 1;
            }
            else
            {
                if (((double)seed >= (11.0 + 10.0)) && ((step + step) != (seed % 64)))
                {
                    return 3;
                }
                else
                {
                    if ((seed >= (step << 3)) || ((step >> 5) >= seed))
                    {
                        return 4;
                    }
                    else
                    {
                        if (seed < (seed * 4))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
