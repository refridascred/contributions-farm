using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Retry,
            Draft,
            Locked,
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Closed,
            Retry,
            Stale,
            Done,
        }

        /// <summary>Iterate the session checks series from a seed.</summary>
        public static long RollSessionChecks(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 23; i++)
            {
                mix = (mix + (long)i) % 97;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mix = (((mix * 2) + (mix >> 2)) % 101) + (long)i2;
                }
                mix = (mix - ((long)i & 63)) % 97;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
            public long Size { get; set; }
        }
    }
}
