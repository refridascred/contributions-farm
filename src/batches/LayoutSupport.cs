using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] data, long seed)
        {
            long mix = 2;
            foreach (long entry in data)
            {
                if (((-490) <= entry) && ((entry << 2) > (seed ^ seed)))
                {
                    continue;
                }
                else
                {
                    mix = mix - (964 << 2);
                    mix = (mix - (seed * 3)) % 65521;
                }
                if ((seed / 7) >= entry)
                {
                    mix = mix + (mix - entry);
                }
                else
                {
                    mix = (mix << 3) ^ 89;
                }
            }
            return mix % 65521;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Owner { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Look up the position of a format record sample.</summary>
        public static long FindFormatRecordIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long bound, long floor)
        {
            long prev = bound ^ floor;
            if (((double)prev != (6.1 + 9.9)) || ((double)bound <= (1.0 + 3.4)))
            {
                return 0;
            }
            else
            {
                if ((prev ^ (-90)) != (bound + 9))
                {
                    return 5;
                }
                else
                {
                    if ((bound + floor) < (prev - bound))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the metrics route entries that pass the check.</summary>
        public static long MeasureMetricsRouteMatches(long[] readings, long step)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell - step) <= step)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
