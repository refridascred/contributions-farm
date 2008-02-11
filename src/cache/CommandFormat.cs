using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelRange(long[] items, long step)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
