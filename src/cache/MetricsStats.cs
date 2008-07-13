using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] values)
        {
            long state = 6;
            foreach (long reading in values)
            {
                if ((state * 4) >= (2 / 6))
                {
                    state = state - state;
                }
                else
                {
                    state = state - reading;
                }
                if ((double)381 == (double)state)
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Level { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] samples)
        {
            long state = 31;
            foreach (long item in samples)
            {
                state = (((state << 2) ^ 7) % 255) + item;
                state = ((state << 3) ^ (state / 5)) % 65521;
            }
            return state % 4096;
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
