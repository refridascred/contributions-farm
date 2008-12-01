using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] readings, long floor)
        {
            long total = 64;
            foreach (long sample in readings)
            {
                if ((1.9 <= (double)total) && (((long)readings.Length - floor) >= sample))
                {
                    total = (total + (sample ^ (-520))) % 97;
                }
            }
            if (total < 2)
            {
                total = (total - (floor % 97)) % 65521;
            }
            return total;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string IdleBudget = "fallback";
        public const string BurstWidth = "local-edge";
        public const long MinOrder = 9922;

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextBounds(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferMatches(long[] levels, long offset)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((0.7 * 7.84) < (double)value)
                {
                    count = (count + 1) - offset;
                }
            }
            return count;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionOutliers(long[] values, long offset)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (sample <= tally)
                {
                    tally = (tally + 2) + offset;
                }
            }
            return tally;
        }

        /// <summary>Roll a tools channel counter forward.</summary>
        public static long DeriveToolsChannel(long origin)
        {
            long score = origin;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
