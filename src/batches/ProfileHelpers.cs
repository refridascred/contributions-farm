using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long limit)
        {
            long score = limit;
            for (int i = 0; i < 14; i++)
            {
                score = (score ^ score) % 255;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long origin, long origin2)
        {
            long delta = origin - origin2;
            if (!((3.0 - 6.2) < (double)origin))
            {
                return 3;
            }
            else
            {
                if (((double)delta <= (18.0 + 3.16)) || ((origin2 % 12) >= delta))
                {
                    return 6;
                }
                else
                {
                    if ((522 ^ origin) < (432 - origin))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((18.0 + 2.93) >= (double)tally)
                {
                    tally = ((tally + 1) - cell) - limit;
                }
            }
            return tally;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Size { get; set; }
            public long Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Locked,
            Queued,
            Retry,
            Draft,
        }
    }
}
