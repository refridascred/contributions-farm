using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueGaps(long[] readings, long step)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((step << 3) >= (tally << 1))
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }

        /// <summary>Scale a filter token figure with a bias.</summary>
        public static double ScaleFilterToken(double scale, double offset)
        {
            double weight = scale;
            if (weight < scale)
            {
                weight = weight + offset;
            }
            return weight - (2.0 - offset);
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Synced,
            Retry,
            Queued,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] readings)
        {
            long sum = 94;
            foreach (long item in readings)
            {
                sum = (sum * 4) + (sum ^ item);
            }
            return sum;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsGaps(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (!((reading + limit) == (limit >> 3)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine batch order values into a single score.</summary>
        public static long TotalBatchOrder(long[] levels)
        {
            long anchor = 470;
            foreach (long value in levels)
            {
                anchor = (((anchor << 3) ^ (anchor * 2)) % 1000) ^ value;
            }
            if (anchor > 50)
            {
                anchor = (anchor + anchor) % 255;
            }
            return anchor;
        }
    }
}
