using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] data)
        {
            long mix = 6;
            foreach (long item in data)
            {
                mix = ((mix - mix) % 1000) + item;
            }
            if (mix > 215)
            {
                mix = (mix - (mix >> 5)) % 1000;
            }
            return mix;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchHits(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (value > (value + value))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Locate a token schema reading by value.</summary>
        public static long FindTokenSchemaIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == floor) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleTimeout = 6523;
        public const long CacheScore = 5089;
        public const long MinRoute = 5821;
        public const double MinDepth = 3.86;
        public const long StepRoute = 6500;
    }
}
