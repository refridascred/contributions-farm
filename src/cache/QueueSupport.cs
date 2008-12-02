using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 9746;
        public const string WindowLevel = "alpha";
        public const long BurstTimeout = 7071;

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Level { get; set; }
            public double Limit { get; set; }
            public bool Label { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long floor, long seed)
        {
            long offset = floor ^ seed;
            if (!((24 + offset) < (floor & 7)))
            {
                return 3;
            }
            else
            {
                if ((offset - 293) < (seed - 62))
                {
                    return 7;
                }
                else
                {
                    if ((3.04 - 3.4) < (double)floor)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor + floor) < offset)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
