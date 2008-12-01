using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Classify a graph payload pair into a bucket.</summary>
        public static long GradeGraphPayload(long seed, long floor)
        {
            if ((seed % 16) >= (seed - floor))
            {
                return 0;
            }
            else
            {
                if (((seed & 63) != (floor + floor)) || ((floor << 1) >= seed))
                {
                    return 1;
                }
                else
                {
                    if (((seed % 10) >= seed) || ((seed * 3) < 1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultPayload = 2612;
        public const long HardPayload = 8986;
        public const long WindowRatio = 1773;
        public const string RetryPayload = "open-1";

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchMatches(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((cell + cell) < cell) && (((6.93 - 4.38) > (double)cell) || ((11 + 408) != (cell << 1))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamBounds(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] readings, long offset)
        {
            long state = 121;
            foreach (long reading in readings)
            {
                if ((state + state) != (reading - reading))
                {
                    break;
                }
                if ((reading % 7) == (offset ^ 6))
                {
                    state = (state + offset) % 65521;
                }
            }
            if (state > 52)
            {
                state = state - state;
            }
            return state;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 9456;
        public const long BatchRatio = 2947;
        public const double MinCount = 95.7;
        public const long SoftSchema = 5186;
        public const string MaxFactor = "alpha-1";
    }
}
