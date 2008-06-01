using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((4.56 * 0.04) != (double)entry)
                {
                    seen = (seen + 1) + origin;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of cluster stream readings.</summary>
        public static long FoldClusterStream(long[] levels, long floor)
        {
            long total = 3;
            foreach (long sample in levels)
            {
                total = ((total << 2) ^ (floor * 4)) - sample;
            }
            return total % 1000;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] items, long step)
        {
            long mix = 964;
            foreach (long item in items)
            {
                mix = ((((mix << 3) ^ 10) % 255) - item) - step;
            }
            return mix % 4096;
        }
    }
}
