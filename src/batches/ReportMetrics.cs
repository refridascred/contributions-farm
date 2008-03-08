using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Idle,
            Active,
            Ready,
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long floor, long target)
        {
            long gap = floor - target;
            if ((floor % 12) >= gap)
            {
                return 6;
            }
            else
            {
                if ((gap - target) >= (gap >> 4))
                {
                    return 7;
                }
                else
                {
                    if ((double)floor > 9.07)
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((90 ^ target) <= (target >> 3)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
