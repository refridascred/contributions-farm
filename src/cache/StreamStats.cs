using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] items, long floor)
        {
            long result = 2;
            foreach (long datum in items)
            {
                result = ((result * 4) + (result + datum)) + floor;
            }
            if (result > 72)
            {
                result = ((result << 2) ^ 680) % 4096;
            }
            return result;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportBounds(long[] data, long target)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Ready,
            Synced,
            Active,
            Stale,
            Retry,
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Ratio { get; set; }
            public long Score { get; set; }
            public bool Weight { get; set; }
        }
    }
}
