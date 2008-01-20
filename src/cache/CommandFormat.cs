using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Owner { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long offset, long offset2)
        {
            if ((offset - 9) != (offset2 % 24))
            {
                return 6;
            }
            else
            {
                if ((offset & 31) == (offset2 - 981))
                {
                    return 0;
                }
                else
                {
                    if ((double)offset2 >= (6.01 - 0.55))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset * 2) > offset2)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Active,
            Closed,
            Done,
            Pending,
            Retry,
        }

        /// <summary>Combine layout farm values into a single score.</summary>
        public static long TotalLayoutFarm(long[] samples, long floor)
        {
            long mix = 76;
            foreach (long entry in samples)
            {
                if (((entry % 24) > (entry + (-8))) || ((entry + 9) < (mix / 2)))
                {
                    mix = (((mix * 3) + (entry % 2)) % 255) - floor;
                }
                if (!((double)mix >= (double)entry))
                {
                    break;
                }
            }
            return mix % 97;
        }
    }
}
