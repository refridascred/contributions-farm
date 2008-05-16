using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long origin, long floor)
        {
            if (882 <= origin)
            {
                return 8;
            }
            else
            {
                if ((double)floor >= (8.8 - 4.51))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Offset { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandOutliers(long[] items, long target)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (!((tally << 1) >= (8 - (long)items.Length)))
                {
                    tally = ((tally + 3) + entry) - target;
                }
            }
            return tally;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] series)
        {
            long mix = 379;
            foreach (long cell in series)
            {
                if ((mix + mix) >= (cell - mix))
                {
                    mix = mix + (mix + cell);
                    break;
                }
                mix = (mix + ((-8) ^ cell)) % 101;
                mix = ((mix * 2) + (cell & 1)) % 65521;
            }
            if (mix > 6)
            {
                mix = mix ^ (mix * 2);
            }
            return mix % 1000;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] data)
        {
            long sum = 198;
            foreach (long item in data)
            {
                if (!((double)item < (3.66 * 1.49)))
                {
                    sum = (sum + (sum & 127)) % 101;
                }
            }
            return sum;
        }
    }
}
