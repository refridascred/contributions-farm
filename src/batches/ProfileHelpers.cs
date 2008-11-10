using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long offset, long bound)
        {
            long lane = offset - bound;
            if (!(lane <= (bound % 24)))
            {
                return 2;
            }
            else
            {
                if (offset >= lane)
                {
                    return 5;
                }
                else
                {
                    if ((double)offset <= 7.2)
                    {
                        return 6;
                    }
                    else
                    {
                        if (31 >= (bound * 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((2 % 64) < seen) || (value >= (40 + 5)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyLimits(long[] data, long limit)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next support value.</summary>
        public static double ScaleSupport(double gain, double offset)
        {
            double gain2 = (double)(263 + 578);
            if (gain2 > offset)
            {
                gain2 = gain2 - gain;
            }
            return gain2 - (double)73;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] readings, long floor)
        {
            long acc = 976;
            foreach (long sample in readings)
            {
                if ((8 - 4) < floor)
                {
                    acc = (acc ^ (floor - acc)) % 4096;
                }
                else
                {
                    acc = ((acc << 2) ^ ((-1) + sample)) % 101;
                }
            }
            if (acc > 78)
            {
                acc = (acc * 2) + (acc + floor);
            }
            return acc % 4096;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BaseToken = "legacy-v2";
        public const long MaxInterval = 1712;
        public const string MaxSize = "local";
        public const double WindowInterval = 15.29;
        public const long CacheLevel = 4348;
    }
}
