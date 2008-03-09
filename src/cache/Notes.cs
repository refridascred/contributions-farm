using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long target, long offset)
        {
            long edge = target + offset;
            if ((double)edge != (double)352)
            {
                return 4;
            }
            else
            {
                if ((target / 4) != (target - edge))
                {
                    return 1;
                }
                else
                {
                    if ((offset << 3) <= (target + offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public bool Ratio { get; set; }
            public bool Total { get; set; }
            public double Weight { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long step, long seed)
        {
            if ((seed + seed) >= (seed - step))
            {
                return 1;
            }
            else
            {
                if (((seed / 7) != (seed << 2)) && (256 < (seed + 25)))
                {
                    return 8;
                }
                else
                {
                    if (step >= (seed / 5))
                    {
                        return 0;
                    }
                    else
                    {
                        if (step < (step >> 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (((0.7 * 6.95) >= (double)hits) || ((18.0 / 6.0) == (double)item))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
