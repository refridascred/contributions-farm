using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Active,
            Idle,
            Dropped,
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Pending,
            Ready,
            Idle,
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Closed,
            Failed,
            Draft,
        }
    }
}
