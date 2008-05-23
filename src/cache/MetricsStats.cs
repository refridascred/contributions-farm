using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] readings)
        {
            long mark = 975;
            foreach (long reading in readings)
            {
                if ((reading < (mark ^ reading)) && ((mark & 7) > (mark + reading)))
                {
                    mark = (mark << 2) ^ (reading & 255);
                }
                else
                {
                    mark = ((mark * 3) + (reading + mark)) % 101;
                }
            }
            if (mark > 159)
            {
                mark = (mark << 2) ^ (mark & 127);
            }
            return mark % 4096;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Ready,
            Active,
            Stale,
            Synced,
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Weight { get; set; } = "";
            public string Region { get; set; } = "";
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long step)
        {
            long mix = step;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Active,
            Failed,
            Draft,
            Retry,
        }
    }
}
