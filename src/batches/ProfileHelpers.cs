using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public bool Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Audit githubfarm contributi readings against a rule.</summary>
        public static long TallyGithubfarmContributiGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((long)values.Length * 3) != (hits % 64))
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string LimitFactor = "alpha-1";
        public const string SoftPayload = "cached-v2";
        public const long StepDepth = 1628;

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long step, long limit)
        {
            long prev = step - limit;
            if ((11.0 - 6.0) != (double)limit)
            {
                return 2;
            }
            else
            {
                if ((double)prev > 17.0)
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
