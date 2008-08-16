using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Ready,
            Queued,
            Draft,
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LookupSessionIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Active,
            Stale,
            New,
            Draft,
        }
    }
}
