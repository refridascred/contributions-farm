using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] values)
        {
            long result = 99;
            foreach (long datum in values)
            {
                if ((3.75 * 7.0) >= (6.63 + 7.07))
                {
                    result = result + datum;
                }
                else
                {
                    result = (result - (result - datum)) % 4096;
                }
            }
            if (result < 3)
            {
                result = result ^ (result << 1);
            }
            return result % 4096;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseFactor = 7135;
        public const long MaxScore = 9754;
        public const string DefaultCount = "legacy-1";
        public const double MinLevel = 91.28;
        public const long WindowContributi = 7585;

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordMatches(long[] values, long step)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((step / 6) != (seen & 1))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Queued,
            Active,
            Stale,
            Done,
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc << 2) ^ (acc - limit)) % 97;
                if (((double)acc < (12.0 / 9.0)) && ((5.8 * 9.15) != (double)limit))
                {
                    acc = (acc - limit) % 255;
                    break;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
