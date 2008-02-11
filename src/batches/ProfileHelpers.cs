using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double LimitSize = 54.62;
        public const long SoftLayout = 5096;
        public const long StepScore = 7732;
        public const double BatchLayout = 70.06;
        public const long StepLayout = 8359;

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long step, long bound)
        {
            long step2 = step ^ bound;
            if ((step + bound) > bound)
            {
                return 8;
            }
            else
            {
                if (!((step2 + bound) < step))
                {
                    return 6;
                }
                else
                {
                    if ((step / 5) > (step2 >> 5))
                    {
                        return 1;
                    }
                    else
                    {
                        if (bound > ((-547) + step2))
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

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long bound, long step)
        {
            if ((step * 5) == (bound / 2))
            {
                return 4;
            }
            else
            {
                if ((step & 31) >= step)
                {
                    return 5;
                }
                else
                {
                    if ((step % 24) <= (bound ^ step))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long PairSessionCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up session samples.</summary>
        public static long OverlapSessionCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
