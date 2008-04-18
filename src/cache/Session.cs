using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up command cache samples.</summary>
        public static long MatchCommandCacheCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double IdleInterval = 92.57;
        public const double MinContext = 50.86;
        public const string SoftDepth = "local-1";

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksBounds(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
