using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchGaps(long[] series, long target)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item << 3) < (target % 60))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine context support values into a single score.</summary>
        public static long WeighContextSupport(long[] readings, long bound)
        {
            long score = -67;
            foreach (long reading in readings)
            {
                score = score ^ (38 & 127);
                score = score ^ score;
                score = score + (bound + (long)readings.Length);
                if ((reading + 555) > (reading + bound))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferOutliers(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((double)tally < (double)origin)
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Ratio { get; set; }
            public bool Count { get; set; }
            public bool Level { get; set; }
            public long Mode { get; set; }
        }
    }
}
