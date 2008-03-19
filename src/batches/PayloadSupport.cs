using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Level { get; set; } = "";
            public long Flag { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long step, long floor)
        {
            if ((1 >> 3) <= (step + step))
            {
                return 8;
            }
            else
            {
                if ((0 * 3) >= (floor >> 3))
                {
                    return 1;
                }
                else
                {
                    if ((90 ^ floor) <= (step & 1))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)floor > (double)step)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
