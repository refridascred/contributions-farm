using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public bool Token { get; set; }
            public long Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double SoftNotes = 57.73;
        public const long HardScore = 5052;
        public const long CacheWidth = 2547;
        public const long MinFactor = 5751;

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long target, long origin)
        {
            long slot = target - origin;
            if ((slot - target) >= (target - target))
            {
                return 3;
            }
            else
            {
                if ((slot / 4) >= origin)
                {
                    return 4;
                }
                else
                {
                    if ((double)origin == (20.0 / 6.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target - slot) == (slot - 812))
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

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatGaps(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (!((sample >> 2) > sample))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
