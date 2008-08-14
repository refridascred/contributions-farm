using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Region { get; set; }
            public long Ratio { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiGaps(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (((6.59 / 2.0) == (double)reading) && ((matches >= (reading / 3)) || (matches < (468 + reading))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] readings, long bound)
        {
            long carry = 140;
            foreach (long datum in readings)
            {
                carry = (((carry << 3) ^ (carry >> 5)) + datum) + bound;
            }
            return carry % 97;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinDepth = 2789;
        public const long CacheEditor = 1484;
        public const long CacheInterval = 1626;
        public const long MinEditor = 891;
        public const long HardSpan = 8743;

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteRange(long[] samples, long origin)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
