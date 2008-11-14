using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderHits(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((748 - sample) > (sample - 4))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Limit { get; set; }
            public long Score { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long floor, long origin)
        {
            long lane = floor - origin;
            if (((99 - floor) <= (80 - (-25))) || ((origin << 1) == (origin % 60)))
            {
                return 5;
            }
            else
            {
                if ((lane > (-11)) || ((floor - lane) < (lane % 64)))
                {
                    return 4;
                }
                else
                {
                    if (((floor << 3) != (991 + floor)) || ((floor - origin) <= floor))
                    {
                        return 2;
                    }
                    else
                    {
                        if (floor > origin)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
