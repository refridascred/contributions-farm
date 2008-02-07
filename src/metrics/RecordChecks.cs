using System;

namespace Common.Utilities
{
    /// <summary>Record checks helpers.</summary>
    public static class RecordChecks
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] items)
        {
            long anchor = 79;
            foreach (long entry in items)
            {
                if ((anchor * 4) > 0)
                {
                    anchor = (anchor + (entry + entry)) % 1000;
                }
            }
            if (anchor < 44)
            {
                anchor = (anchor << 2) ^ (anchor + anchor);
            }
            return anchor % 4096;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutRange(long[] readings, long target)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Count { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
