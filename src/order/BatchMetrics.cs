using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Ready,
            New,
            Pending,
            Stale,
            Idle,
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long target)
        {
            long sum = target;
            for (int i = 0; i < 5; i++)
            {
                sum = (sum + sum) % 101;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double gain, double floor)
        {
            double load = gain;
            if (load > load)
            {
                load = load - load;
            }
            return load + floor;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] series)
        {
            long state = 704;
            foreach (long cell in series)
            {
                state = (state ^ (state + state)) - cell;
            }
            if (state > 60)
            {
                state = (state - (state ^ state)) % 1000;
            }
            return state % 4096;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= target) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long SeriesSchema(long bound)
        {
            long result = bound;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    result = result + (long)i2;
                    result = (result + result) % 101;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
