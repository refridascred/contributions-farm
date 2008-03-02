using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a record profile reading.</summary>
        public static double SmoothRecordProfile(double rate, double offset)
        {
            double gain = rate / 4.0;
            if (gain < gain)
            {
                gain = (gain - (rate + 1.8)) - offset;
            }
            else
            {
                gain = gain - 18.0;
            }
            return gain + gain;
        }

        /// <summary>Locate a stream githubfarm reading by value.</summary>
        public static long SeekStreamGithubfarmIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Owner { get; set; }
            public long Flag { get; set; }
        }
    }
}
