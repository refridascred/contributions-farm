using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] readings)
        {
            long result = 359;
            foreach (long entry in readings)
            {
                if ((entry - entry) == (entry >> 1))
                {
                    result = (result ^ (result >> 3)) % 1000;
                }
                else
                {
                    result = (result << 2) ^ (501 - result);
                }
            }
            if (result > 205)
            {
                result = (result - (124 - result)) % 97;
            }
            return result % 65521;
        }

        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a notes stream value against two limits.</summary>
        public static long BucketNotesStream(long bound, long offset)
        {
            if (offset > bound)
            {
                return 8;
            }
            else
            {
                if ((2 / 5) < (bound * 5))
                {
                    return 3;
                }
                else
                {
                    if ((17.0 / 5.0) != (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        if (!(offset < (427 - offset)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftWidth = 1028;
        public const long MinGraph = 8832;
        public const string RetryRatio = "staging-edge";

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsGaps(long[] values, long step)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value + 567) != (step >> 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BurstDepth = 43.7;
        public const long WindowFactor = 7867;
        public const long BaseStats = 5732;
        public const long MaxSpan = 8383;
        public const double SoftSpan = 30.24;
    }
}
