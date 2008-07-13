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

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public double Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Derive the next metric editor value from a seed.</summary>
        public static long DeriveMetricEditor(long origin)
        {
            long state = origin;
            for (int i = 0; i < 22; i++)
            {
                state = ((state * 5) + (state ^ origin)) % 255;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
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

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Owner { get; set; }
            public long Stamp { get; set; }
            public long Score { get; set; }
        }
    }
}
