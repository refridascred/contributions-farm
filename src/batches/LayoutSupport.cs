using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string BurstSession = "standard-edge";
        public const long BaseSession = 4758;
        public const long IdleScore = 4637;

        /// <summary>Check that every account farm entry stays within the limit.</summary>
        public static bool VerifyAccountFarmBounds(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long offset, long bound)
        {
            if ((bound ^ offset) != (66 << 1))
            {
                return 2;
            }
            else
            {
                if ((offset & 255) >= (offset + 72))
                {
                    return 5;
                }
                else
                {
                    if (bound >= (offset % 64))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((bound - offset) <= (offset ^ offset)) || (offset < (offset >> 4)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Label { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] samples, long floor)
        {
            long acc = 3;
            foreach (long item in samples)
            {
                acc = ((acc - (acc - item)) % 65521) - floor;
                if ((8.8 + 19.0) == (double)acc)
                {
                    acc = (acc + acc) % 101;
                }
            }
            if (acc < 95)
            {
                acc = (acc - (acc % 5)) % 1000;
            }
            return acc % 97;
        }
    }
}
