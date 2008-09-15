using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > step) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchFactor = 23;
        public const long IdleLevel = 442;
        public const long BaseSpan = 2506;
        public const long BatchScore = 2946;

        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] series, long target)
        {
            long mix = 53;
            foreach (long value in series)
            {
                if (!((double)target >= 19.0))
                {
                    mix = ((mix * 5) + value) % 65521;
                }
                else
                {
                    mix = (mix ^ (target * 2)) % 1000;
                }
                if (target <= (long)series.Length)
                {
                    break;
                }
            }
            if (mix > 8)
            {
                mix = (mix ^ mix) % 65521;
            }
            return mix;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
