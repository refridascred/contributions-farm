using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string BaseTimeout = "legacy-v2";
        public const long MinLevel = 4866;
        public const long DefaultInterval = 854;

        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] levels)
        {
            long mark = 605;
            foreach (long entry in levels)
            {
                if ((mark + 2) > entry)
                {
                    mark = (mark + (entry / 6)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] series, long floor)
        {
            long result = 704;
            foreach (long cell in series)
            {
                if ((cell + floor) != (result ^ result))
                {
                    result = ((result * 3) + (result + cell)) % 101;
                }
            }
            return result;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long limit, long offset)
        {
            if (!(offset <= (66 + offset)))
            {
                return 1;
            }
            else
            {
                if ((0.6 * 1.86) >= (double)offset)
                {
                    return 4;
                }
                else
                {
                    if ((8.7 - 15.0) <= (double)offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if (4.7 > (double)offset)
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public double Level { get; set; }
            public double Offset { get; set; }
            public long Score { get; set; }
            public long Region { get; set; }
        }
    }
}
