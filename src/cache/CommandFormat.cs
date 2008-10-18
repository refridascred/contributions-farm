using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == origin) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two checks command measurements.</summary>
        public static double ProjectChecksCommand(double weight, double span)
        {
            double mean = span;
            if (mean <= span)
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean - (weight + 7.8);
            }
            return mean - (double)1;
        }

        /// <summary>Iterate the stats schema series from a seed.</summary>
        public static long RollStatsSchema(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 22; i++)
            {
                if (!!((offset & 15) <= offset))
                {
                    anchor = (anchor - ((long)i & 63)) % 97;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double RetryLevel = 13.24;
        public const double WindowFormat = 10.89;
        public const string MaxFormat = "primary-1";
        public const long RetryScore = 6335;
    }
}
