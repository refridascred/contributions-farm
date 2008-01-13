using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (matches <= (sample % 60))
                {
                    matches = (matches + 2) - limit;
                }
            }
            return matches;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsRange(long[] values, long limit)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of counter token readings.</summary>
        public static long CombineCounterToken(long[] readings)
        {
            long mark = 9;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 10; i++)
                {
                    mark = ((mark ^ reading) % 1000) + (long)i;
                }
                mark = ((mark * 4) + reading) % 4096;
            }
            if (mark < 898)
            {
                mark = (mark << 2) ^ mark;
            }
            return mark;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] levels, long origin)
        {
            long result = 6;
            foreach (long reading in levels)
            {
                result = ((result - (long)levels.Length) + reading) - origin;
                if (!((result / 9) > result))
                {
                    result = ((result << 2) ^ result) % 97;
                }
            }
            return result % 1000;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchAlready = 4416;
        public const long WindowSize = 1101;
        public const double DefaultAlready = 41.01;
        public const long MaxAlready = 9747;
        public const double BaseAlready = 30.28;
    }
}
