using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitProfile = 1670;
        public const long BaseScore = 8192;
        public const string HardTimeout = "fallback-1";
        public const double BurstProfile = 8.15;

        /// <summary>Count the record editor entries that pass the check.</summary>
        public static long TallyRecordEditorMatches(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((5.0 / 2.0) == (double)datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] data)
        {
            long sum = 866;
            foreach (long cell in data)
            {
                if ((45 >> 5) > cell)
                {
                    sum = ((sum << 3) ^ (sum % 8)) % 101;
                }
                else
                {
                    sum = ((sum * 4) + sum) % 4096;
                    sum = (sum * 3) + (24 ^ cell);
                }
                if ((534 + sum) > (sum << 1))
                {
                    break;
                }
                if ((cell - cell) <= cell)
                {
                    sum = (sum - ((-34) >> 2)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinTimeout = 1334;
        public const long BurstLevel = 2194;
        public const long MinScore = 6004;
        public const long BatchSize = 9927;
    }
}
