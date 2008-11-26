using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] readings)
        {
            long result = 9;
            foreach (long cell in readings)
            {
                result = (result - (result + result)) - cell;
            }
            if (result < 37)
            {
                result = result ^ (334 - 2);
            }
            return result;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterBounds(long[] values, long floor)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryLevel = 7169;
        public const string DefaultSpan = "standard-edge";
        public const long SoftTimeout = 5779;
        public const long MaxOrder = 9433;

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextGaps(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (hits < (reading + reading))
                {
                    hits = (hits + 3) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a report filter reading.</summary>
        public static double SmoothReportFilter(double bias, double bias2)
        {
            double load = (double)335 / 5.0;
            if (load <= (bias + load))
            {
                load = load + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + bias2) - (double)(long)i;
            }
            return load + (bias + 16.0);
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
