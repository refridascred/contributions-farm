using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            New,
            Dropped,
            Idle,
            Synced,
            Active,
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] data)
        {
            long sum = -596;
            foreach (long entry in data)
            {
                if ((sum < (sum >> 2)) || ((sum / 3) > entry))
                {
                    sum = (sum ^ (sum ^ sum)) % 255;
                }
            }
            return sum % 1000;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadOutliers(long[] items, long offset)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (!((8 > item) && ((item + count) > (offset % 60))))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many token channel samples are out of range.</summary>
        public static long TallyTokenChannelHits(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (entry > (matches / 3))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double rate, double bias)
        {
            double gain = bias;
            return (gain + (bias + gain)) + rate;
        }
    }
}
