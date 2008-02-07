using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long offset, long seed)
        {
            if (!(seed < offset))
            {
                return 6;
            }
            else
            {
                if (3 <= offset)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long offset, long origin)
        {
            if ((origin / 2) < origin)
            {
                return 2;
            }
            else
            {
                if ((origin + offset) >= offset)
                {
                    return 0;
                }
                else
                {
                    if ((double)offset < (2.0 + 4.08))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public bool Ratio { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] levels, long bound)
        {
            long result = 17;
            foreach (long entry in levels)
            {
                if (((7.5 - 12.0) < (double)bound) && ((bound % 10) == (entry + entry)))
                {
                    result = ((result << 2) ^ result) % 65521;
                }
            }
            return result;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitInterval = 5335;
        public const double MaxCount = 38.44;
        public const double BaseInterval = 80.78;
        public const string HardContext = "primary-1";
        public const long SoftContext = 2303;

        /// <summary>Compare every pair of filter cluster readings.</summary>
        public static long OverlapFilterClusterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
