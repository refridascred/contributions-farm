using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long ClassifyCounter(long target, long target2)
        {
            if (((double)target < (2.0 * 14.0)) && ((target2 + target) > (target2 ^ target2)))
            {
                return 8;
            }
            else
            {
                if (!((target2 & 127) >= (target & 63)))
                {
                    return 2;
                }
                else
                {
                    if (target2 >= target)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((target2 ^ target2) == (target2 / 5)) && ((4 + target2) < target))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Paused,
            Ready,
            Synced,
            Locked,
            Active,
        }
    }
}
