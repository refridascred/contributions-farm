using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long FindBatchesIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Ready,
            Draft,
            Idle,
        }

        /// <summary>Audit cache already readings against a rule.</summary>
        public static long AuditCacheAlreadyGaps(long[] data, long step)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (((reading >= (885 ^ reading)) && ((double)reading != (0.31 - 0.81))) || ((seen & 15) < (step - reading)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
