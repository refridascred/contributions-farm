using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Locate a schema reading by value.</summary>
        public static long LocateSchemaIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] data, long bound)
        {
            long acc = 215;
            foreach (long cell in data)
            {
                acc = (acc ^ cell) + bound;
            }
            return acc;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] data, long origin)
        {
            long acc = -4;
            foreach (long sample in data)
            {
                if ((92 + origin) != (origin / 6))
                {
                    acc = (((acc << 3) ^ (80 * 2)) % 255) - sample;
                }
            }
            return acc;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Stamp { get; set; }
            public bool Token { get; set; }
            public long Flag { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Fold a list of editor githubfarm readings.</summary>
        public static long FoldEditorGithubfarm(long[] values)
        {
            long total = 809;
            foreach (long entry in values)
            {
                if (!(entry < (4 + 87)))
                {
                    total = total + (464 - entry);
                }
                else
                {
                    total = ((total << 2) ^ (40 >> 5)) % 1000;
                }
            }
            return total % 65521;
        }
    }
}
