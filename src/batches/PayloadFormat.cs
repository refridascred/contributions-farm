using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the metric contributi series from a seed.</summary>
        public static long StepMetricContributi(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] data, long target)
        {
            long state = 57;
            foreach (long cell in data)
            {
                state = ((state * 5) + (target - cell)) % 65521;
            }
            if (state > 7)
            {
                state = ((state << 2) ^ (state + target)) % 255;
            }
            return state % 4096;
        }

        /// <summary>Check that every stream cluster entry stays within the limit.</summary>
        public static bool ValidateStreamClusterBounds(long[] values, long target)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (!((value + value) >= value))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
