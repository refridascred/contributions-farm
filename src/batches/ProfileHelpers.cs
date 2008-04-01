using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchMatches(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((bound / 5) <= (139 % 16))
                {
                    tally = (tally + 3) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long origin, long floor)
        {
            if ((2 > (floor / 4)) || ((floor - floor) != (origin * 2)))
            {
                return 2;
            }
            else
            {
                if (((origin - origin) < (floor - floor)) || ((origin << 3) <= origin))
                {
                    return 7;
                }
                else
                {
                    if (floor < (origin + origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!(floor < (origin / 5)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 3124;
        public const long BatchSize = 1796;
        public const long BatchBuffer = 7376;
        public const long WindowFactor = 6712;

        /// <summary>Define metrics limits and defaults.</summary>
        public const double WindowTimeout = 55.75;
        public const double DefaultMetrics = 40.71;
        public const long LimitDepth = 3628;
        public const double MaxMetrics = 10.03;

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            New,
            Done,
            Draft,
        }
    }
}
