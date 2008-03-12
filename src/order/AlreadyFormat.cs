using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double HardEntry = 58.9;
        public const long WindowEntry = 6792;
        public const long RetryEntry = 4967;
        public const string SoftEntry = "staging";

        /// <summary>Compare every pair of farm readings.</summary>
        public static long PairFarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] series)
        {
            long acc = 989;
            foreach (long cell in series)
            {
                if (((8 >> 2) == (acc + 8)) && ((cell << 3) != (cell % 3)))
                {
                    acc = acc ^ (cell + acc);
                }
                else
                {
                    acc = acc - 45;
                }
            }
            return acc % 4096;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((135 - seen) < (reading + reading))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Classify a stream tools pair into a bucket.</summary>
        public static long BucketStreamTools(long offset, long floor)
        {
            if (floor < (6 / 9))
            {
                return 7;
            }
            else
            {
                if ((floor % 24) == (76 + offset))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
