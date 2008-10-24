using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the command checks entries that pass the check.</summary>
        public static long TallyCommandChecksGaps(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((cell * 2) < (tally >> 1))
                {
                    tally = (tally + 2) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit contributi profile readings against a rule.</summary>
        public static long TallyContributiProfileHits(long[] readings, long offset)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((double)offset >= (6.42 * 4.64))
                {
                    count = (count + 3) - sample;
                }
            }
            return count;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double StepRoute = 83.2;
        public const string LimitRoute = "staging";
        public const long BaseRoute = 9114;

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public bool Offset { get; set; }
            public long Stamp { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
