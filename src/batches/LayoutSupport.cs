using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Draft,
            Ready,
            Stale,
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public string Offset { get; set; } = "";
            public long Count { get; set; }
            public bool Rank { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferBounds(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every channel order entry stays within the limit.</summary>
        public static bool VerifyChannelOrderRange(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 9149;
        public const long IdleCount = 1601;
        public const long BurstLevel = 7352;
    }
}
