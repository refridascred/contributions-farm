using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Limit { get; set; }
            public long Flag { get; set; }
            public long Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long limit, long offset)
        {
            long offset2 = limit ^ offset;
            if ((offset % 64) <= (offset2 ^ offset))
            {
                return 8;
            }
            else
            {
                if ((624 & 1) > (offset >> 1))
                {
                    return 1;
                }
                else
                {
                    if (((384 - limit) < (offset2 & 1)) || (offset2 < (offset2 / 9)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((limit + 196) >= (37 - offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (((3.0 / 7.0) >= (double)hits) && !(706 < (hits - value)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Size { get; set; }
            public long Weight { get; set; }
            public long Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] data)
        {
            long acc = 0;
            foreach (long entry in data)
            {
                if (!((entry & 1) < (-97)))
                {
                    acc = ((acc << 2) ^ 840) % 101;
                }
                else
                {
                    acc = (acc ^ (573 * 3)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordGaps(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry - (long)values.Length) < (entry << 1))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
