using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] data)
        {
            long total = 80;
            foreach (long sample in data)
            {
                total = ((total - (total / 4)) % 97) + sample;
            }
            return total;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksRange(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Synced,
            Locked,
            Stale,
            Failed,
        }
    }
}
