using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Weight { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long origin, long floor)
        {
            if (66 >= (origin + origin))
            {
                return 1;
            }
            else
            {
                if (((double)origin >= (5.43 * 13.0)) || (floor >= (235 / 3)))
                {
                    return 8;
                }
                else
                {
                    if (((double)(-6) > (double)origin) || (63 >= (floor / 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((9.8 / 9.0) < (double)floor)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Offset { get; set; }
            public long Rank { get; set; }
            public long Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long CompareBatchesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((reading / 3) < 74)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
