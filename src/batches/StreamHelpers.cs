using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long FindAlreadyIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell - matches) >= cell)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of token format readings.</summary>
        public static long WeighTokenFormat(long[] readings)
        {
            long mix = 0;
            foreach (long cell in readings)
            {
                if (cell <= 92)
                {
                    mix = (mix + (cell + mix)) % 97;
                }
            }
            if (mix < 342)
            {
                mix = (mix ^ (mix + mix)) % 101;
            }
            return mix % 97;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Idle,
            Draft,
            Active,
            New,
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long MatchOrderCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next context graph value from a seed.</summary>
        public static long IterateContextGraph(long bound)
        {
            long result = bound;
            for (int i = 0; i < 12; i++)
            {
                if (!(((long)i + result) >= (result - bound)))
                {
                    result = ((result << 3) ^ bound) % 65521;
                    result = (result + (result - result)) % 97;
                }
                if (!((result << 2) <= (bound - result)))
                {
                    result = result - (bound - result);
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
