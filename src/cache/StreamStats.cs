using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LocateReportIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 23; i++)
            {
                carry = (carry << 3) ^ (offset >> 4);
                if ((offset * 4) > offset)
                {
                    carry = ((carry * 5) + (offset * 5)) % 4096;
                    carry = carry + carry;
                }
                if (!((230 * 5) < offset))
                {
                    carry = ((carry << 2) ^ (carry / 9)) % 101;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (!(((item >> 5) <= (item % 8)) && ((seed >> 4) < (count << 1))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorOutliers(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!(((double)datum <= (double)count) || (count < ((long)data.Length + 7))))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
