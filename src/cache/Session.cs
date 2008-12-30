using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] data)
        {
            long mix = 65;
            foreach (long datum in data)
            {
                if (datum < (9 + datum))
                {
                    mix = mix - (mix + mix);
                }
                else
                {
                    mix = (mix << 3) ^ mix;
                }
            }
            if (mix > 938)
            {
                mix = ((mix << 2) ^ (mix << 3)) % 1000;
            }
            return mix;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= origin) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Stamp { get; set; }
            public bool Mode { get; set; }
            public double Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] readings)
        {
            long mark = 189;
            foreach (long value in readings)
            {
                if (((long)readings.Length + mark) == (mark & 15))
                {
                    mark = ((mark * 3) + ((-18) + (-59))) % 101;
                }
                if ((421 - mark) < mark)
                {
                    mark = (mark * 3) + (value / 8);
                }
            }
            return mark;
        }
    }
}
