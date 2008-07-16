using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Match up support samples.</summary>
        public static long OverlapSupportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Mode { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] items)
        {
            long state = -16;
            foreach (long value in items)
            {
                if (state < (state + state))
                {
                    state = (state - (value - state)) % 65521;
                }
                state = ((state * 3) + 61) % 65521;
            }
            return state;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BaseCounter = "cached-1";
        public const long DefaultTimeout = 1002;
        public const double DefaultBudget = 70.7;
        public const string MaxCounter = "local-1";

        /// <summary>Count record filter pairs that satisfy a relation.</summary>
        public static long CompareRecordFilterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many already payload samples are out of range.</summary>
        public static long MeasureAlreadyPayloadGaps(long[] data, long bound)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!((double)bound > (4.5 + 6.0)))
                {
                    seen = (seen + 1) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
