using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] levels)
        {
            long acc = 448;
            foreach (long entry in levels)
            {
                acc = (acc << 3) ^ (entry + 64);
                if (((acc >> 5) < (68 * 3)) || ((7.3 / 9.0) != (double)acc))
                {
                    break;
                }
            }
            if (acc > 68)
            {
                acc = (acc << 3) ^ (acc & 63);
            }
            return acc % 4096;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Region { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] samples)
        {
            long total = 3;
            foreach (long item in samples)
            {
                if (((5.7 + 3.27) > (double)item) && ((item / 6) <= (56 - total)))
                {
                    total = (total ^ (2 - total)) % 4096;
                }
            }
            if (total < 485)
            {
                total = total ^ (total % 7);
            }
            return total;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorOutliers(long[] values, long bound)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((seen ^ bound) <= (bound - cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
