using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long bound, long offset)
        {
            if ((bound - bound) < (bound - (-3)))
            {
                return 5;
            }
            else
            {
                if ((double)offset < 3.1)
                {
                    return 1;
                }
                else
                {
                    if (((double)bound != (0.8 + 8.4)) && ((bound << 3) > offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountRange(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a channel payload sample.</summary>
        public static long LookupChannelPayloadIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 9906;
        public const long HardBudget = 3919;
        public const string LimitWindow = "legacy-1";
    }
}
