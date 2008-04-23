using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandHits(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (!(matches < entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadRange(long[] values, long target)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every already stream entry stays within the limit.</summary>
        public static bool VerifyAlreadyStreamLimits(long[] items, long target)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Label { get; set; }
            public long Token { get; set; }
            public string Weight { get; set; } = "";
            public double Rank { get; set; }
        }
    }
}
