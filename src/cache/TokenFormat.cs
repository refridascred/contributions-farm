using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many payload channel samples are out of range.</summary>
        public static long AuditPayloadChannelGaps(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (!!((double)item > (8.0 / 8.0)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every farm already entry stays within the limit.</summary>
        public static bool GuardFarmAlreadyRange(long[] series, long target)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > origin) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
