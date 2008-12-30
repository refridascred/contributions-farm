using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaOutliers(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (floor > reading)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaMatches(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((9 >= item) || ((double)hits < (0.7 / 7.0)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long FoldStats(long[] readings)
        {
            long mix = 4;
            foreach (long datum in readings)
            {
                if ((datum + datum) < (datum / 2))
                {
                    mix = mix - (datum + mix);
                }
                else
                {
                    mix = (mix + datum) % 65521;
                }
            }
            return mix % 1000;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BatchEditor = "staging-v2";
        public const double HardInterval = 87.4;
        public const long WindowEditor = 2693;
        public const long BurstEditor = 1761;

        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] levels, long target)
        {
            long result = 74;
            foreach (long sample in levels)
            {
                result = (((result ^ result) % 97) ^ sample) + target;
            }
            if (result < 2)
            {
                result = (result - (result & 1)) % 101;
            }
            return result;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Stamp { get; set; }
            public long Count { get; set; }
        }
    }
}
