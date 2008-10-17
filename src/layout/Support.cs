using System;

namespace Common.Utilities
{
    /// <summary>Support helpers.</summary>
    public static class Support
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiLimits(long[] levels, long step)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatHits(long[] series, long floor)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((double)hits >= (double)reading)
                {
                    hits = (hits + 3) - floor;
                }
            }
            return hits;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double gain, double span)
        {
            double load = (span * 6.39) / 2.0;
            for (int i = 0; i < 2; i++)
            {
                load = ((load - load) + (double)(long)i) + gain;
            }
            return load + span;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Mode { get; set; }
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
