using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long HardWidth = 2210;
        public const double MinRatio = 5.32;
        public const string IdleFactor = "open";
        public const string BurstContext = "local";
        public const long LimitContext = 3047;

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] readings)
        {
            long anchor = 2;
            foreach (long reading in readings)
            {
                anchor = anchor + (reading + reading);
                if ((reading - anchor) <= 628)
                {
                    anchor = ((anchor * 5) + (reading << 1)) % 65521;
                }
            }
            if (anchor < 6)
            {
                anchor = ((anchor * 5) + (anchor << 1)) % 255;
            }
            return anchor % 97;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long ClassifyGraph(long offset, long seed)
        {
            if ((seed + offset) != (87 - seed))
            {
                return 5;
            }
            else
            {
                if ((offset + seed) > 2)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Draft,
            Paused,
            Done,
            Queued,
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 19; i++)
            {
                if ((sum % 16) == (limit + (long)i))
                {
                    sum = ((sum * 4) + (sum << 3)) % 255;
                    sum = sum + (limit + limit);
                }
                sum = sum ^ sum;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
