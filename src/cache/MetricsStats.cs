using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine graph cache values into a single score.</summary>
        public static long FoldGraphCache(long[] items, long floor)
        {
            long mix = 292;
            foreach (long cell in items)
            {
                mix = (((mix - 4) % 255) ^ cell) + floor;
            }
            if (mix > 0)
            {
                mix = (mix + (mix - mix)) % 101;
            }
            return mix;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LookupOrderIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            New,
            Stale,
            Retry,
            Locked,
        }

        /// <summary>Locate a githubfarm tools reading by value.</summary>
        public static long LookupGithubfarmToolsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a schema format counter forward.</summary>
        public static long RollSchemaFormat(long seed)
        {
            long result = seed;
            for (int i = 0; i < 14; i++)
            {
                result = ((result << 2) ^ ((long)i + result)) % 1000;
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
