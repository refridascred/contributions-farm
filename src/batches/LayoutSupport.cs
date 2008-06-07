using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Queued,
            Dropped,
            Failed,
            Pending,
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long floor)
        {
            long score = floor;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyGaps(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((0.1 - 3.89) >= (double)entry)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many session command samples are out of range.</summary>
        public static long AuditSessionCommandGaps(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((count / 6) < count)
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }
    }
}
