using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Rank { get; set; }
            public double Weight { get; set; }
            public double Stamp { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 16; i++)
            {
                if ((floor - floor) <= floor)
                {
                    carry = (carry - (floor % 5)) % 97;
                    carry = carry + (carry + floor);
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseBudget = 8644;
        public const double MaxFilter = 9.59;
        public const long DefaultFilter = 5604;
        public const long SoftFilter = 9685;
        public const long BaseCount = 2553;

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] values)
        {
            long mix = -78;
            foreach (long item in values)
            {
                mix = ((mix - (191 + mix)) % 97) - item;
            }
            if (mix > 607)
            {
                mix = ((mix << 3) ^ (mix + mix)) % 4096;
            }
            return mix % 97;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesHits(long[] series, long floor)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (seen < (floor - sample))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
