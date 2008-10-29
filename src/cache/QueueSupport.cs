using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long StepFormat(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 14; i++)
            {
                if ((222 - mix) == (long)i)
                {
                    mix = (mix - mix) % 255;
                    mix = (mix + (floor ^ floor)) % 97;
                }
                else
                {
                    mix = (mix << 2) ^ (floor + floor);
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value * 5) == (value % 60))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultSize = 3939;
        public const long RetryInterval = 4658;
        public const long BatchCommits = 5021;
    }
}
