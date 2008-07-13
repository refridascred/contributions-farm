using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCount = 8144;
        public const string RetryCommand = "alpha-edge";
        public const double SoftCommand = 26.67;

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            New,
            Ready,
            Done,
            Pending,
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

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] values, long floor)
        {
            long carry = 246;
            foreach (long datum in values)
            {
                carry = ((carry + (850 % 8)) % 97) - datum;
            }
            if (carry > 32)
            {
                carry = (carry - floor) % 4096;
            }
            return carry;
        }
    }
}
