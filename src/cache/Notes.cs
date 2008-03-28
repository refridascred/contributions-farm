using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string SoftSpan = "latest";
        public const double StepFactor = 29.09;
        public const double DefaultBudget = 83.61;

        /// <summary>Validate support stream readings against a bound.</summary>
        public static bool CheckSupportStreamBounds(long[] series, long limit)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= offset) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit tools record readings against a rule.</summary>
        public static long TallyToolsRecordGaps(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((count << 3) <= cell)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Draft,
            Ready,
            Closed,
        }
    }
}
