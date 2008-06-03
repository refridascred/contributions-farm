using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamHits(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((matches * 3) > cell)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] data)
        {
            long mix = 184;
            foreach (long value in data)
            {
                if (((419 + mix) != (mix / 5)) && ((759 + 1) >= value))
                {
                    mix = (mix + (value / 6)) % 255;
                }
                else
                {
                    mix = (mix + (value - value)) % 4096;
                }
            }
            if (mix < 4)
            {
                mix = (mix << 2) ^ (mix - mix);
            }
            return mix % 1000;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double DefaultFormat = 28.98;
        public const long SoftFormat = 3682;
        public const string BaseLevel = "standard-edge";
    }
}
