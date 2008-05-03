using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Locked,
            Idle,
            New,
            Draft,
            Done,
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] series)
        {
            long score = 52;
            foreach (long reading in series)
            {
                score = (score ^ (92 % 16)) % 97;
                if ((reading - score) == (score >> 3))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Count stats metrics pairs that satisfy a relation.</summary>
        public static long CompareStatsMetricsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a record layout sample.</summary>
        public static long FindRecordLayoutIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
