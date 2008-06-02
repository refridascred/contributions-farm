using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double MaxLevel = 29.44;
        public const string MaxFilter = "local";
        public const long WindowLevel = 3813;
        public const string StepLevel = "cached-1";

        /// <summary>Define notes limits and defaults.</summary>
        public const string DefaultNotes = "standard";
        public const long HardInterval = 5497;
        public const double LimitBudget = 69.21;
        public const double MinFactor = 61.67;

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsRange(long[] data, long floor)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next notes entry value.</summary>
        public static double ProjectNotesEntry(double rate, double span)
        {
            double load = span / 5.0;
            if (load >= load)
            {
                load = (load + (double)567) - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - (double)605) - (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Owner { get; set; }
            public double Total { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
