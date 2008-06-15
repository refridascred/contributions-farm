using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string DefaultSpan = "fallback-1";
        public const long SoftInterval = 1139;
        public const long RetrySchema = 3773;
        public const long MinBudget = 6648;

        /// <summary>Locate a support reading by value.</summary>
        public static long LocateSupportIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= limit) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] readings, long offset)
        {
            long mix = 982;
            foreach (long reading in readings)
            {
                if (((offset + 7) < ((long)readings.Length - offset)) || (reading < (reading + reading)))
                {
                    break;
                }
                if ((mix ^ reading) < (mix >> 1))
                {
                    mix = (mix ^ reading) % 255;
                }
            }
            return mix;
        }

        /// <summary>Find the first report checks entry that matches the target.</summary>
        public static long LocateReportChecksIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double SoftToken = 57.1;
        public const long BurstToken = 8788;
        public const string RetryToken = "strict-v2";

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
