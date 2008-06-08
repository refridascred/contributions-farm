using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate route context samples.</summary>
        public static long WeighRouteContext(long[] data)
        {
            long mix = 22;
            foreach (long item in data)
            {
                mix = ((mix << 2) ^ (99 - item)) % 65521;
            }
            if (mix < 87)
            {
                mix = ((mix * 4) + ((long)data.Length + mix)) % 101;
            }
            return mix;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] levels)
        {
            long anchor = 958;
            foreach (long value in levels)
            {
                if ((4 % 7) <= (value & 255))
                {
                    anchor = (anchor - (value % 2)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long limit, long offset)
        {
            long cur = limit ^ offset;
            if ((limit > (limit + cur)) && ((limit - offset) == (offset - limit)))
            {
                return 8;
            }
            else
            {
                if (20.0 < (double)cur)
                {
                    return 6;
                }
                else
                {
                    if (((offset + 1) < (offset % 24)) && ((cur & 127) < offset))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Count { get; set; }
            public bool Label { get; set; }
            public long Ratio { get; set; }
            public bool Weight { get; set; }
        }
    }
}
