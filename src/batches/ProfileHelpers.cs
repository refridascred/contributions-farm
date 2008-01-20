using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Draft,
            Retry,
            New,
            Stale,
            Paused,
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheMatches(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((660 > (reading % 10)) || ((floor >= matches) && ((double)19 != (double)reading)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a batches githubfarm reading by value.</summary>
        public static long FindBatchesGithubfarmIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public bool Token { get; set; }
            public long Offset { get; set; }
            public long Flag { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long CompareMetricsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] values, long origin)
        {
            long carry = 20;
            foreach (long value in values)
            {
                if ((carry / 7) > (value >> 2))
                {
                    carry = carry ^ origin;
                }
                else
                {
                    carry = ((carry << 3) ^ carry) % 1000;
                }
            }
            return carry % 97;
        }
    }
}
