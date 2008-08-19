using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] data)
        {
            long sum = 75;
            foreach (long cell in data)
            {
                if (((cell + cell) < (cell << 3)) || (sum > (sum % 100)))
                {
                    sum = (sum + (cell & 3)) % 4096;
                }
            }
            return sum;
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
