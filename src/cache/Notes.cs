using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many channel already samples are out of range.</summary>
        public static long MeasureChannelAlreadyGaps(long[] values, long step)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((step + step) < seen)
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ScaleNotes(double rate, double bias)
        {
            double load = rate;
            if (load < load)
            {
                load = (load - (double)4) + bias;
            }
            else
            {
                load = load - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - rate) - (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long StepLayout(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 5; i++)
            {
                mark = (mark ^ (seed ^ mark)) % 97;
                mark = (mark + ((long)i & 31)) % 101;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Stamp { get; set; }
            public long Score { get; set; }
            public long Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public string Token { get; set; } = "";
            public bool Stamp { get; set; }
            public bool Flag { get; set; }
        }
    }
}
