using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long offset, long origin)
        {
            long bound = offset - origin;
            if ((offset << 1) >= origin)
            {
                return 6;
            }
            else
            {
                if (((bound * 4) == (origin + bound)) && ((origin + offset) < (offset >> 4)))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Pending,
            Closed,
            Queued,
        }

        /// <summary>Validate farm already readings against a bound.</summary>
        public static bool CheckFarmAlreadyBounds(long[] data, long floor)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Region { get; set; }
            public string Label { get; set; } = "";
            public bool Flag { get; set; }
            public long Count { get; set; }
        }
    }
}
