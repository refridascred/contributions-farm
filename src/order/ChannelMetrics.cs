using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long HardDepth = 3733;
        public const long BaseAlready = 850;
        public const long WindowAlready = 8318;
        public const long IdleAlready = 1085;
        public const long SoftDepth = 3895;

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchHits(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((double)tally > 3.9)
                {
                    tally = (tally + 1) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextBounds(long[] values, long target)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
