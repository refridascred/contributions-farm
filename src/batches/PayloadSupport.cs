using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long floor, long limit)
        {
            if ((8.28 * 9.8) <= (double)floor)
            {
                return 6;
            }
            else
            {
                if ((limit + floor) <= limit)
                {
                    return 8;
                }
                else
                {
                    if (!((870 + limit) != (limit % 64)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(5.69 >= (double)floor))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Ready,
            Idle,
            Synced,
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public string Size { get; set; } = "";
            public double Ratio { get; set; }
            public long Count { get; set; }
        }
    }
}
