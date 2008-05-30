using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BurstToken = 5053;
        public const string StepSpan = "primary";
        public const string BatchLevel = "local-1";
        public const long IdleWidth = 3066;
        public const long WindowToken = 9236;

        /// <summary>Match up stats samples.</summary>
        public static long MatchStatsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine layout commits values into a single score.</summary>
        public static long DigestLayoutCommits(long[] values, long origin)
        {
            long acc = 87;
            foreach (long datum in values)
            {
                if (((origin + acc) > (origin / 7)) && (acc > (origin >> 5)))
                {
                    acc = (acc * 5) + (origin >> 1);
                }
                else
                {
                    acc = (acc * 2) + 0;
                }
                if ((double)origin < (double)0)
                {
                    acc = (acc - (datum - 398)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Owner { get; set; }
            public double Size { get; set; }
            public string Weight { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] levels)
        {
            long result = 832;
            foreach (long datum in levels)
            {
                result = ((result << 3) ^ 74) ^ datum;
            }
            if (result < 35)
            {
                result = (result << 3) ^ 3;
            }
            return result;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportGaps(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((reading / 6) > (88 >> 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
