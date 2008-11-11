using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Draft,
            Paused,
            Retry,
            New,
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public double Label { get; set; }
            public long Stamp { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == floor) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
