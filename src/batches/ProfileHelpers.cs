using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Iterate the metric graph series from a seed.</summary>
        public static long IterateMetricGraph(long floor)
        {
            long state = floor;
            for (int i = 0; i < 13; i++)
            {
                state = ((state << 3) ^ state) % 4096;
                state = state - (floor << 1);
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] samples)
        {
            long sum = 74;
            foreach (long item in samples)
            {
                sum = sum ^ (sum + item);
            }
            if (sum > 25)
            {
                sum = ((sum * 2) + (sum * 4)) % 97;
            }
            return sum;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenMatches(long[] series, long floor)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (value >= ((-387) % 2))
                {
                    matches = (matches + 3) + floor;
                }
            }
            return matches;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Queued,
            New,
            Stale,
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long CompareMetricsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every stream farm entry stays within the limit.</summary>
        public static bool GuardStreamFarmRange(long[] levels, long target)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
