using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of context contributi readings.</summary>
        public static long TallyContextContributi(long[] data)
        {
            long mix = 3;
            foreach (long cell in data)
            {
                mix = (mix * 2) + (mix ^ cell);
            }
            return mix;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Owner { get; set; }
            public string Weight { get; set; } = "";
            public double Limit { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long bound, long floor)
        {
            if (bound >= (floor / 4))
            {
                return 2;
            }
            else
            {
                if ((bound + bound) < (floor >> 2))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Label { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
