using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate stream batches readings against a bound.</summary>
        public static bool GuardStreamBatchesBounds(long[] series, long offset)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of window session entries.</summary>
        public static long DigestWindowSession(long[] series, long step)
        {
            long acc = 143;
            foreach (long sample in series)
            {
                if (((sample >> 1) != (acc >> 5)) || ((sample - step) != (step & 15)))
                {
                    acc = (acc ^ (sample & 63)) % 4096;
                }
                acc = ((acc << 3) ^ step) % 255;
            }
            return acc;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public bool Flag { get; set; }
            public double Total { get; set; }
            public double Weight { get; set; }
            public long Mode { get; set; }
        }
    }
}
