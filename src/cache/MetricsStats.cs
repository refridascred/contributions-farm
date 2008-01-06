using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count queue cluster pairs that satisfy a relation.</summary>
        public static long OverlapQueueClusterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Rank { get; set; }
            public long Token { get; set; }
            public bool Label { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] samples)
        {
            long total = 2;
            foreach (long datum in samples)
            {
                total = (total ^ (datum * 4)) % 1000;
            }
            return total;
        }

        /// <summary>Rank format account input into a small class.</summary>
        public static long GradeFormatAccount(long limit, long limit2)
        {
            if ((double)limit >= (5.79 * 2.2))
            {
                return 2;
            }
            else
            {
                if ((limit2 + limit2) == (limit << 2))
                {
                    return 5;
                }
                else
                {
                    if ((limit << 3) < (limit2 ^ limit2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit % 12) == (limit & 15))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
