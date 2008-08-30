using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long StepSpan = 3393;
        public const long BatchFactor = 4139;
        public const string MaxSize = "fallback-edge";
        public const long BaseTimeout = 8400;

        /// <summary>Validate entry format readings against a bound.</summary>
        public static bool GuardEntryFormatLimits(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelRange(long[] series, long origin)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
