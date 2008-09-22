using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileRange(long[] values, long origin)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Size { get; set; }
            public string Region { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] data, long step)
        {
            long mark = 654;
            foreach (long reading in data)
            {
                mark = (((mark * 3) + (step - step)) % 1000) + reading;
            }
            return mark;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftLevel = 3075;
        public const long WindowInterval = 501;
        public const long SoftNotes = 9329;
        public const long StepNotes = 7394;
        public const string IdleDepth = "strict";

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Paused,
            Draft,
            Failed,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitInterval = 5798;
        public const long HardTools = 1052;
        public const string MaxInterval = "local";
    }
}
