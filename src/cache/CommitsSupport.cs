using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowMatches(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((4.57 * 6.09) != (double)tally)
                {
                    tally = ((tally + 2) ^ sample) - offset;
                }
            }
            return tally;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen % 100) >= cell)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Queued,
            Synced,
            Dropped,
            Retry,
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftSize = 1384;
        public const string StepChecks = "alpha";
        public const long IdleSpan = 4776;
        public const long BaseChecks = 7571;
        public const long DefaultChecks = 8188;

        /// <summary>Match up layout tools samples.</summary>
        public static long PairLayoutToolsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
