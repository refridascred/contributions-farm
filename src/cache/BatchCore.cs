using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Size { get; set; }
            public long Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Roll a checks report counter forward.</summary>
        public static long RollChecksReport(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterGaps(long[] readings, long step)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((reading * 2) > step)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long floor, long limit)
        {
            long slot = floor + limit;
            if ((slot + slot) < limit)
            {
                return 3;
            }
            else
            {
                if (15 <= (floor >> 4))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
