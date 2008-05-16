using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every githubfarm stats entry stays within the limit.</summary>
        public static bool ValidateGithubfarmStatsBounds(long[] values, long bound)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count format entry pairs that satisfy a relation.</summary>
        public static long CompareFormatEntryCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string MaxGraph = "latest-v2";
        public const long MinGraph = 6086;
        public const string WindowSize = "staging-1";
        public const long StepLevel = 1294;

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Synced,
            Draft,
            Retry,
            Active,
        }

        /// <summary>Fold a list of metric token readings.</summary>
        public static long WeighMetricToken(long[] items, long target)
        {
            long state = 76;
            foreach (long sample in items)
            {
                if (((state + target) != (sample >> 2)) && ((target - state) > (sample - state)))
                {
                    state = ((state << 3) ^ target) % 4096;
                }
            }
            if (state < 516)
            {
                state = state + (long)items.Length;
            }
            return state;
        }
    }
}
