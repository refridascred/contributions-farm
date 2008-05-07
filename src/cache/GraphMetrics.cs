using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Roll a checks account counter forward.</summary>
        public static long RollChecksAccount(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Region { get; set; }
            public long Ratio { get; set; }
            public long Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsOutliers(long[] series, long origin)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)item >= (5.2 + 8.62))
                {
                    seen = (seen + 1) + origin;
                }
            }
            return seen;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Rank { get; set; }
            public long Level { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long offset, long offset2)
        {
            if (offset >= (90 * 3))
            {
                return 0;
            }
            else
            {
                if ((8.86 * 2.0) < (double)offset2)
                {
                    return 8;
                }
                else
                {
                    if ((offset2 & 3) >= (76 >> 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
