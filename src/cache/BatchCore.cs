using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] readings)
        {
            long state = 924;
            foreach (long item in readings)
            {
                state = (state + (item % 60)) % 255;
                if ((state * 5) < (item << 3))
                {
                    break;
                }
            }
            if (state > 707)
            {
                state = (state - (state * 2)) % 255;
            }
            return state;
        }

        /// <summary>Accumulate stream stats samples.</summary>
        public static long TallyStreamStats(long[] data, long offset)
        {
            long mix = 4;
            foreach (long item in data)
            {
                mix = ((mix ^ (mix - item)) % 255) - offset;
            }
            return mix;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long bound, long origin)
        {
            if ((bound * 3) < 940)
            {
                return 7;
            }
            else
            {
                if ((double)origin != (double)bound)
                {
                    return 1;
                }
                else
                {
                    if ((origin * 5) <= origin)
                    {
                        return 3;
                    }
                    else
                    {
                        if (origin <= ((-719) % 2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Label { get; set; } = "";
            public long Score { get; set; }
            public string Rank { get; set; } = "";
            public double Token { get; set; }
        }
    }
}
