using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Pending,
            Queued,
            Failed,
            Stale,
            New,
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long RollWindow(long step)
        {
            long total = step;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Match up window graph samples.</summary>
        public static long OverlapWindowGraphCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatLimits(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
