using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionMatches(long[] data, long step)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((8.13 * 5.0) >= (double)matches) && ((3.7 - 9.3) == (double)cell))
                {
                    matches = (matches + 2) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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

        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] values)
        {
            long anchor = 53;
            foreach (long item in values)
            {
                if ((anchor ^ anchor) >= (item << 1))
                {
                    anchor = ((anchor * 2) + (item + anchor)) % 1000;
                    anchor = (anchor - (item + anchor)) % 101;
                }
                if (anchor >= (anchor + item))
                {
                    anchor = (anchor ^ item) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public bool Region { get; set; }
            public long Weight { get; set; }
        }
    }
}
