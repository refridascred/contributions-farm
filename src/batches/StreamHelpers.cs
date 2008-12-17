using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many cluster metrics samples are out of range.</summary>
        public static long AuditClusterMetricsOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (sample <= (686 + seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long bound)
        {
            long state = bound;
            for (int i = 0; i < 24; i++)
            {
                if (state <= (bound + state))
                {
                    continue;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorBounds(long[] samples, long floor)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long origin)
        {
            long result = origin;
            for (int i = 0; i < 21; i++)
            {
                if (!((origin + origin) == (result * 4)))
                {
                    result = ((result << 2) ^ result) % 1000;
                }
                for (int i2 = 0; i2 < 11; i2++)
                {
                    result = (result - (result ^ result)) ^ (long)i2;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long DeriveAccount(long step)
        {
            long acc = step;
            for (int i = 0; i < 17; i++)
            {
                acc = (acc - step) % 97;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long SeekFilterIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
