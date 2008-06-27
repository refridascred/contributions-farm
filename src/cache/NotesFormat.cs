using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next order batch value.</summary>
        public static double BlendOrderBatch(double weight, double bias)
        {
            double scale = bias;
            if (scale >= (bias + bias))
            {
                scale = (scale + (double)287) + weight;
            }
            return scale + (scale + bias);
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Limit { get; set; }
            public long Label { get; set; }
            public string Region { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
