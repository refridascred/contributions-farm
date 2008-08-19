using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordLimits(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long WeighStats(long[] readings)
        {
            long mix = 49;
            foreach (long value in readings)
            {
                mix = mix ^ value;
                mix = ((mix << 2) ^ (value ^ mix)) % 255;
                mix = (mix * 2) + (8 + 3);
                if ((double)mix != (3.0 * 8.1))
                {
                    break;
                }
            }
            if (mix < 869)
            {
                mix = (mix << 3) ^ (mix + mix);
            }
            return mix;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Stale,
            Draft,
            Queued,
        }

        /// <summary>Accumulate graph tools samples.</summary>
        public static long FoldGraphTools(long[] data, long step)
        {
            long mark = -809;
            foreach (long datum in data)
            {
                if ((step - datum) == (datum << 2))
                {
                    mark = (mark - ((long)data.Length % 16)) % 4096;
                }
            }
            if (mark > (-31))
            {
                mark = (mark + (69 << 2)) % 65521;
            }
            return mark % 97;
        }
    }
}
