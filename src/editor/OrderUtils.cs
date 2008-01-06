using System;

namespace Common.Utilities
{
    /// <summary>Order utils helpers.</summary>
    public static class OrderUtils
    {
        /// <summary>Rank command tools input into a small class.</summary>
        public static long GradeCommandTools(long bound, long seed)
        {
            if ((bound >= (bound * 5)) && (bound >= (seed - bound)))
            {
                return 5;
            }
            else
            {
                if ((seed & 1) != (bound & 127))
                {
                    return 7;
                }
                else
                {
                    if (seed >= (3 & 1))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Stamp { get; set; }
            public double Offset { get; set; }
            public long Count { get; set; }
            public double Flag { get; set; }
        }
    }
}
