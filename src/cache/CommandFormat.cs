using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long limit, long target)
        {
            if ((double)limit <= 6.27)
            {
                return 3;
            }
            else
            {
                if ((double)limit <= 11.0)
                {
                    return 8;
                }
                else
                {
                    if ((double)limit > (9.1 * 7.1))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)target < (double)limit) && ((double)limit >= 7.9))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Owner { get; set; }
            public string Weight { get; set; } = "";
            public double Limit { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public bool Limit { get; set; }
            public bool Weight { get; set; }
            public long Level { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Label { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
