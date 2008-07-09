using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long limit, long limit2)
        {
            if ((0 >> 5) < (limit & 63))
            {
                return 8;
            }
            else
            {
                if ((limit >> 5) == (limit2 - limit2))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Dropped,
            Queued,
            Locked,
            Closed,
            Synced,
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public bool Offset { get; set; }
            public string Level { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long origin, long target)
        {
            if (((origin + origin) < origin) || ((727 - target) <= (origin + 2)))
            {
                return 8;
            }
            else
            {
                if ((target & 127) < (target - origin))
                {
                    return 6;
                }
                else
                {
                    if ((target < (origin % 24)) && (origin < (target >> 4)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (target >= origin)
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
