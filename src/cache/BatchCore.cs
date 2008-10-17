using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Closed,
            New,
            Draft,
        }

        /// <summary>Count context metrics pairs that satisfy a relation.</summary>
        public static long MatchContextMetricsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a record context reading by value.</summary>
        public static long LocateRecordContextIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((1 & 63) < (tally ^ entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
