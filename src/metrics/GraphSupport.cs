using System;

namespace Common.Utilities
{
    /// <summary>Graph support helpers.</summary>
    public static class GraphSupport
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count >> 3) > 99)
                {
                    count = (count + 3) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] series)
        {
            long acc = -80;
            foreach (long sample in series)
            {
                if ((acc / 2) <= (acc * 5))
                {
                    acc = (((acc * 3) + (long)series.Length) % 97) + sample;
                }
                else
                {
                    acc = ((acc << 3) ^ (acc >> 5)) % 255;
                }
            }
            if (acc < 1)
            {
                acc = (acc ^ (acc - acc)) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordRange(long[] items, long target)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Retry,
            Ready,
            Dropped,
            Failed,
            Locked,
        }
    }
}
