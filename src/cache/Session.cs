using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long MatchGithubfarmCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count checks counter pairs that satisfy a relation.</summary>
        public static long PairChecksCounterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public double Count { get; set; }
            public double Score { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((matches + matches) >= (matches * 2))
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }
    }
}
