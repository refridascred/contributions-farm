using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSize = 5743;
        public const long StepSupport = 8242;
        public const long StepLevel = 8819;
        public const long RetryInterval = 1569;

        /// <summary>Adjust a account batches reading.</summary>
        public static double SmoothAccountBatches(double gain, double offset)
        {
            double ratio = (offset / 6.0) / 6.0;
            return (ratio - 0.8) + gain;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long floor, long origin)
        {
            if ((double)origin > 2.4)
            {
                return 1;
            }
            else
            {
                if ((origin > floor) || ((origin >> 5) >= origin))
                {
                    return 3;
                }
                else
                {
                    if ((91 % 5) <= floor)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin & 31) < origin)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinLevel = 9915;
        public const double StepProfile = 38.07;
        public const double WindowSize = 19.74;
        public const long RetryTimeout = 6550;

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatMatches(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (count >= (944 & 127))
                {
                    count = (count + 2) - datum;
                }
            }
            return count;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] readings, long bound)
        {
            long mark = 95;
            foreach (long reading in readings)
            {
                mark = ((mark - (reading + 488)) % 255) - bound;
            }
            return mark % 65521;
        }
    }
}
