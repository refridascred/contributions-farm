using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a stats session counter forward.</summary>
        public static long IterateStatsSession(long step)
        {
            long mark = step;
            for (int i = 0; i < 15; i++)
            {
                if (!((double)mark < (double)step))
                {
                    mark = ((mark * 2) + mark) % 255;
                }
                else
                {
                    mark = ((mark << 2) ^ (mark / 5)) % 101;
                }
                mark = ((mark << 2) ^ (mark + (long)i)) % 1000;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Ready,
            Active,
            Done,
            Dropped,
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmOutliers(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((cell >> 5) > (cell + cell))
                {
                    hits = (hits + 1) + seed;
                }
            }
            return hits;
        }
    }
}
