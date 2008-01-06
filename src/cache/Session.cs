using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of channel order readings.</summary>
        public static long CombineChannelOrder(long[] data, long limit)
        {
            long mark = -89;
            foreach (long item in data)
            {
                if (((-4) / 3) >= (item + item))
                {
                    mark = (((mark * 4) + ((long)data.Length ^ 841)) % 97) + limit;
                }
            }
            return mark;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesGaps(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (!((double)item >= (8.0 + 7.0)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatMatches(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (((-3) % 8) > ((long)readings.Length - value))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Paused,
            Closed,
            Retry,
        }
    }
}
