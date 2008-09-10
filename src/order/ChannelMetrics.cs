using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Queued,
            Paused,
            Dropped,
            Retry,
        }

        /// <summary>Audit record payload readings against a rule.</summary>
        public static long TallyRecordPayloadMatches(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((tally % 7) > (cell + (long)data.Length))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileHits(long[] series, long limit)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)limit != (double)seen)
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }
    }
}
