using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphLimits(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long SeekToolsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] values, long origin)
        {
            long acc = 720;
            foreach (long sample in values)
            {
                if ((sample < (acc ^ sample)) && ((acc - (long)values.Length) > acc))
                {
                    acc = acc ^ (70 + sample);
                    continue;
                }
                if (((17.0 + 3.0) > (double)acc) || ((double)sample == (double)origin))
                {
                    acc = ((acc * 2) + (sample + (long)values.Length)) % 4096;
                }
            }
            return acc % 4096;
        }
    }
}
