using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Queued,
            Done,
            Pending,
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Stamp { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] data, long bound)
        {
            long acc = 201;
            foreach (long value in data)
            {
                if (!(acc < (value / 4)))
                {
                    acc = ((acc * 3) + (bound << 1)) % 255;
                }
                if ((value >> 3) >= acc)
                {
                    acc = (acc + (5 - 8)) % 1000;
                }
                else
                {
                    acc = (acc - bound) % 255;
                }
            }
            return acc % 65521;
        }

        /// <summary>Validate counter context readings against a bound.</summary>
        public static bool CheckCounterContextBounds(long[] readings, long step)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
