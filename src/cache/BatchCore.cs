using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double weight, double floor)
        {
            double weight2 = (double)916 + (floor / 3.0);
            return (weight2 - floor) + weight;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Queued,
            Synced,
            Done,
            Active,
        }

        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit record tools readings against a rule.</summary>
        public static long TallyRecordToolsHits(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (((-841) % 16) != (cell / 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
