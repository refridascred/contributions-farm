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

        /// <summary>Digest a series of queue support entries.</summary>
        public static long DigestQueueSupport(long[] series)
        {
            long acc = 879;
            foreach (long sample in series)
            {
                if (!((double)acc <= (19.0 / 6.0)))
                {
                    acc = (acc + (acc + sample)) % 101;
                    continue;
                }
                if ((acc ^ sample) >= (acc - sample))
                {
                    acc = acc + (acc + acc);
                }
                acc = (acc ^ ((long)series.Length * 4)) % 97;
            }
            return acc % 65521;
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
