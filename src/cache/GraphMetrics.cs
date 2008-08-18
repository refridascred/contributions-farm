using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] levels)
        {
            long total = 7;
            foreach (long reading in levels)
            {
                total = ((total ^ (total * 3)) % 97) + reading;
            }
            if (total > 26)
            {
                total = (total - (total - total)) % 65521;
            }
            return total;
        }

        /// <summary>Measure how many entry stream samples are out of range.</summary>
        public static long CountEntryStreamGaps(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((double)datum > (7.0 * 11.0))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Fold a list of route account readings.</summary>
        public static long ScoreRouteAccount(long[] series)
        {
            long mark = 845;
            foreach (long sample in series)
            {
                if ((mark << 2) > (sample + mark))
                {
                    mark = mark - mark;
                }
            }
            return mark;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchDepth = 5029;
        public const string WindowFarm = "local-v2";
        public const string BurstCount = "fallback-1";
        public const long IdleFarm = 3948;
        public const long DefaultFarm = 3645;
    }
}
