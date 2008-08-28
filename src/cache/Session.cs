using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphOutliers(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)count > (6.3 / 9.0))
                {
                    count = (count + 3) ^ value;
                }
            }
            return count;
        }

        /// <summary>Locate a githubfarm counter reading by value.</summary>
        public static long SeekGithubfarmCounterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= seed) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the channel farm entries that pass the check.</summary>
        public static long CountChannelFarmGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((960 & 255) > matches) || !((matches * 3) > (value + value)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public double Score { get; set; }
            public long Ratio { get; set; }
            public double Total { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
