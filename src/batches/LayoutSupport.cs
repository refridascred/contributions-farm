using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public bool Weight { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsMatches(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count + item) > (6 << 2))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Done,
            Pending,
            Idle,
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double SmoothReport(double ratio, double offset)
        {
            double load = (double)(23 ^ (-81));
            for (int i = 0; i < 8; i++)
            {
                load = (((load + (double)218) + (double)(long)i) - ratio) - offset;
            }
            return load + (double)2;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowChecks = 9403;
        public const long BaseChecks = 7967;
        public const long MaxSpan = 4220;
    }
}
