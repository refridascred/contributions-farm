using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferBounds(long[] series, long step)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public bool Score { get; set; }
            public string Owner { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
