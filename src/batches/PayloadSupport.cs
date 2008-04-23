using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long RankRecord(long origin, long step)
        {
            long edge = origin + step;
            if ((edge - step) <= (origin & 1))
            {
                return 5;
            }
            else
            {
                if ((step & 31) >= (origin >> 4))
                {
                    return 7;
                }
                else
                {
                    if ((edge >> 5) > (origin * 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long CompareWindowCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Owner { get; set; } = "";
            public long Label { get; set; }
            public string Flag { get; set; } = "";
            public bool Weight { get; set; }
        }
    }
}
