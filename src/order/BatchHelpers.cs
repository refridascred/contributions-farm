using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] readings, long bound)
        {
            long mix = 771;
            foreach (long datum in readings)
            {
                mix = mix ^ mix;
                if ((mix / 8) > (mix & 127))
                {
                    mix = mix + datum;
                }
                if ((datum + mix) < datum)
                {
                    mix = (mix - (bound >> 4)) % 101;
                }
                if ((double)(long)readings.Length >= (3.2 + 6.33))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Failed,
            Draft,
            Stale,
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long step)
        {
            long carry = step;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
