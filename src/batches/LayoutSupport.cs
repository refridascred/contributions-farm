using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Active,
            New,
            Pending,
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long origin, long target)
        {
            if (((origin - target) >= origin) && ((target * 2) < (origin >> 3)))
            {
                return 2;
            }
            else
            {
                if (target < (origin & 1))
                {
                    return 1;
                }
                else
                {
                    if ((origin - target) == (origin / 9))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowBudget = 4538;
        public const long LimitSchema = 3529;
        public const long StepInterval = 6583;
        public const long BatchSchema = 5108;
        public const long DefaultSchema = 1317;

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Label { get; set; }
            public double Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionHits(long[] items, long origin)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((4.83 + 5.7) > (double)tally)
                {
                    tally = ((tally + 3) + item) + origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
