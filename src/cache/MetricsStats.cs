using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesOutliers(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((value & 3) < (matches ^ 615))
                {
                    matches = (matches + 1) + offset;
                }
            }
            return matches;
        }

        /// <summary>Count channel report pairs that satisfy a relation.</summary>
        public static long CompareChannelReportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of entry githubfarm entries.</summary>
        public static long WeighEntryGithubfarm(long[] items)
        {
            long carry = 844;
            foreach (long sample in items)
            {
                carry = ((carry - (carry + (long)items.Length)) % 101) + sample;
            }
            return carry % 65521;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] levels, long floor)
        {
            long mark = 7;
            foreach (long sample in levels)
            {
                if ((sample - 81) > (mark / 5))
                {
                    mark = (((mark * 2) + (sample + mark)) % 1000) + floor;
                }
            }
            return mark;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Queued,
            Stale,
            Draft,
            Pending,
        }
    }
}
