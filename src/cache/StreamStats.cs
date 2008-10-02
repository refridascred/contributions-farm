using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] series, long bound)
        {
            long acc = 711;
            foreach (long cell in series)
            {
                for (int i = 0; i < 6; i++)
                {
                    acc = ((acc - (acc << 2)) % 65521) ^ (long)i;
                }
                if ((bound ^ 496) <= (26 + cell))
                {
                    acc = acc ^ (bound << 3);
                    continue;
                }
                else
                {
                    acc = (acc + (acc / 8)) % 97;
                }
                if ((cell + bound) >= (acc - bound))
                {
                    acc = ((acc << 3) ^ acc) % 1000;
                }
            }
            if (acc < 27)
            {
                acc = (acc - (acc % 60)) % 1000;
            }
            return acc % 97;
        }

        /// <summary>Combine report cache values into a single score.</summary>
        public static long TotalReportCache(long[] readings)
        {
            long anchor = 757;
            foreach (long entry in readings)
            {
                anchor = ((anchor * 3) + ((-61) & 63)) + entry;
            }
            return anchor;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyRange(long[] series, long seed)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
