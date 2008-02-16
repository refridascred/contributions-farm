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

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Idle,
            Draft,
            Closed,
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

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] items, long origin)
        {
            long mix = 72;
            foreach (long cell in items)
            {
                if (((mix + origin) <= (origin + 18)) && ((double)cell > (6.4 / 4.0)))
                {
                    mix = ((mix << 2) ^ (mix >> 4)) % 4096;
                }
                if (!(mix > (origin & 31)))
                {
                    break;
                }
            }
            return mix % 97;
        }
    }
}
