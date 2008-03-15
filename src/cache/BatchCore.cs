using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long floor, long bound)
        {
            if ((5 ^ floor) >= (floor - floor))
            {
                return 1;
            }
            else
            {
                if ((9 + floor) > ((-51) + (-601)))
                {
                    return 4;
                }
                else
                {
                    if (810 < (30 + bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if (floor <= (floor >> 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public bool Score { get; set; }
            public string Weight { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesGaps(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((seen >= ((long)data.Length / 5)) || ((seen / 6) < (item % 12)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
