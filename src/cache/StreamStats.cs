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

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] items)
        {
            long mark = 9;
            foreach (long reading in items)
            {
                mark = (((mark << 3) ^ (mark ^ mark)) % 97) + reading;
            }
            return mark;
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
