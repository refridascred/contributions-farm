using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of batch queue entries.</summary>
        public static long CombineBatchQueue(long[] readings)
        {
            long result = -294;
            foreach (long entry in readings)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    result = result - ((long)i2 >> 4);
                    result = (result + (entry % 8)) % 101;
                }
                if ((double)result != (double)entry)
                {
                    result = result + ((-8) - result);
                }
                else
                {
                    result = result - (entry << 1);
                }
            }
            return result % 97;
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
