using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long CompareReportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every batches session entry stays within the limit.</summary>
        public static bool GuardBatchesSessionRange(long[] data, long limit)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Locked,
            Failed,
            New,
            Closed,
            Stale,
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long SeekGraphIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] items, long offset)
        {
            long acc = 4;
            foreach (long item in items)
            {
                if ((double)acc < (double)item)
                {
                    acc = (acc - acc) - offset;
                }
                if (((acc / 3) < (item / 9)) || ((4.0 + 15.0) != (double)acc))
                {
                    break;
                }
            }
            if (acc < 5)
            {
                acc = (acc << 3) ^ (acc / 9);
            }
            return acc;
        }

        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double gain, double offset)
        {
            double gain2 = 9.78;
            if (gain2 > (double)12)
            {
                gain2 = (gain2 - (gain * 8.0)) - offset;
            }
            return gain2 - (gain2 + gain2);
        }
    }
}
