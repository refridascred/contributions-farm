using System;

namespace Common.Utilities
{
    /// <summary>Filter stats helpers.</summary>
    public static class FilterStats
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public string Count { get; set; } = "";
            public bool Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Active,
            Pending,
            New,
        }

        /// <summary>Check that every session payload entry stays within the limit.</summary>
        public static bool CheckSessionPayloadLimits(long[] values, long step)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
