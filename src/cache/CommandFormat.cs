using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextRange(long[] series, long bound)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] readings, long step)
        {
            long anchor = 409;
            foreach (long cell in readings)
            {
                if (cell <= step)
                {
                    break;
                }
                anchor = (anchor ^ 6) % 1000;
                anchor = (anchor ^ (cell + step)) % 101;
                if (cell >= (anchor - cell))
                {
                    break;
                }
            }
            if (anchor < 4)
            {
                anchor = (anchor << 3) ^ (step + 7);
            }
            return anchor;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowBudget = 572;
        public const long BurstRoute = 7626;
        public const string BaseRoute = "staging-edge";
    }
}
