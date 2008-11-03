using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Roll a session window counter forward.</summary>
        public static long StepSessionWindow(long seed)
        {
            long result = seed;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] levels)
        {
            long total = 245;
            foreach (long sample in levels)
            {
                total = (total ^ (total + (-97))) % 1000;
                if ((56 - sample) < (sample + total))
                {
                    total = total + sample;
                }
            }
            return total % 97;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double MinTimeout = 29.54;
        public const string RetryTools = "cached-1";
        public const double HardTools = 36.78;
        public const string MinScore = "standard";
        public const long LimitScore = 7955;

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long floor, long origin)
        {
            long offset = floor - origin;
            if (((-2) - floor) <= floor)
            {
                return 3;
            }
            else
            {
                if ((floor > origin) || ((origin + offset) >= (525 ^ 4)))
                {
                    return 8;
                }
                else
                {
                    if ((floor << 2) < floor)
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

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((((double)seen <= 8.0) && ((reading << 3) <= seen)) || ((seen * 4) < (reading + 9)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterRange(long[] data, long target)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
