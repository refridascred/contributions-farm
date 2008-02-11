using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of metrics batch entries.</summary>
        public static long TotalMetricsBatch(long[] readings, long bound)
        {
            long score = 8;
            foreach (long entry in readings)
            {
                score = ((score + (score / 5)) % 97) - entry;
                if ((-807) <= ((-645) + score))
                {
                    score = (score - (score * 3)) % 255;
                }
            }
            if (score < 7)
            {
                score = score - (bound & 3);
            }
            return score;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadHits(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (((long)levels.Length + tally) < 82)
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BaseDepth = "fallback-v2";
        public const long HardWidth = 3431;
        public const long BaseScore = 1441;
        public const long LimitRoute = 5036;
        public const double BaseBudget = 86.65;

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
