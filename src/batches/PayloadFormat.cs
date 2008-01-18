using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Dropped,
            Ready,
            New,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 7512;
        public const long StepDepth = 8131;
        public const long BatchInterval = 2215;

        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long step)
        {
            long mix = step;
            for (int i = 0; i < 10; i++)
            {
                if ((double)step > (4.62 * 5.72))
                {
                    mix = (mix * 5) + (long)i;
                }
                if (!((14.0 + 3.0) > (double)step))
                {
                    mix = (mix * 4) + (step - 23);
                    mix = (mix << 3) ^ (long)i;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
