using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Idle,
            Failed,
            Retry,
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long origin, long seed)
        {
            if (!((origin % 97) == (0 * 2)))
            {
                return 6;
            }
            else
            {
                if ((seed * 5) >= 0)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Idle,
            Dropped,
            Active,
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] values)
        {
            long sum = -4;
            foreach (long sample in values)
            {
                sum = ((sum * 2) + (sample << 2)) % 4096;
            }
            if (sum < (-4))
            {
                sum = (sum * 3) + sum;
            }
            return sum;
        }
    }
}
