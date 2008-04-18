using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long origin, long target)
        {
            if ((1.18 / 3.0) < (double)target)
            {
                return 1;
            }
            else
            {
                if ((origin % 3) == (target / 7))
                {
                    return 0;
                }
                else
                {
                    if ((target >> 3) < target)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin < 63) || ((origin << 3) == (origin + origin)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Level { get; set; }
            public string Weight { get; set; } = "";
            public double Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string RetryLayout = "standard-edge";
        public const long HardLayout = 2076;
        public const long BatchBudget = 1723;
    }
}
