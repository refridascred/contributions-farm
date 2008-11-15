using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LocateSchemaIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long target, long target2)
        {
            if (!((1.14 - 5.8) < (double)target))
            {
                return 8;
            }
            else
            {
                if ((target / 9) >= (target2 / 4))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] items)
        {
            long result = 370;
            foreach (long cell in items)
            {
                result = (result + (cell * 3)) % 1000;
            }
            return result % 65521;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsMatches(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((9.43 - 4.0) >= (double)reading)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public double Limit { get; set; }
            public long Ratio { get; set; }
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
