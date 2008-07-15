using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftCount = 9430;
        public const long LimitGraph = 5083;
        public const long StepGraph = 2979;
        public const long CacheTimeout = 2084;
        public const string DefaultSpan = "open-edge";

        /// <summary>Blend two profile measurements.</summary>
        public static double ProjectProfile(double ratio, double offset)
        {
            double ratio2 = offset;
            if (ratio2 < ratio2)
            {
                ratio2 = ratio2 + (offset * 2.7);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 + offset) + (double)(long)i;
            }
            return ratio2 + (ratio / 7.0);
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long bound)
        {
            long state = bound;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Grade a entry cluster value against two limits.</summary>
        public static long GradeEntryCluster(long floor, long step)
        {
            if ((floor / 7) < step)
            {
                return 5;
            }
            else
            {
                if (((step + step) > (floor - floor)) || ((step << 2) > floor))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Ready,
            Active,
            Failed,
            Queued,
        }
    }
}
