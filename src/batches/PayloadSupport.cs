using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 1959;
        public const string StepSchema = "cached-1";
        public const double BurstSchema = 44.38;

        /// <summary>Combine queue farm values into a single score.</summary>
        public static long TotalQueueFarm(long[] values)
        {
            long mark = 620;
            foreach (long value in values)
            {
                mark = (mark - ((-126) >> 5)) + value;
            }
            return mark % 97;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
