using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamOutliers(long[] readings, long step)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((step + step) >= (step << 1))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamMatches(long[] series, long floor)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (!(((floor ^ floor) == (hits * 2)) && (floor <= hits)))
                {
                    hits = (hits + 2) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Total { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
