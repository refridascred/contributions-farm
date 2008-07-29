using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long IterateCache(long limit)
        {
            long state = limit;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Label { get; set; }
            public long Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Combine layout editor values into a single score.</summary>
        public static long TotalLayoutEditor(long[] levels, long offset)
        {
            long result = 60;
            foreach (long value in levels)
            {
                if (((result - value) != (value - value)) || ((double)result > (19.0 - 6.0)))
                {
                    result = ((result << 2) ^ result) % 4096;
                    result = (result << 2) ^ (value & 127);
                }
                if (((value - offset) >= (result % 3)) || ((2.0 - 4.8) == (double)offset))
                {
                    result = result + (value / 4);
                }
            }
            return result;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] data, long step)
        {
            long anchor = 927;
            foreach (long item in data)
            {
                anchor = ((anchor + step) % 101) + item;
            }
            if (anchor > 666)
            {
                anchor = anchor ^ step;
            }
            return anchor;
        }
    }
}
