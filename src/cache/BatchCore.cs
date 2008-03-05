using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] items)
        {
            long total = 551;
            foreach (long item in items)
            {
                if ((total & 7) >= (item & 15))
                {
                    total = (total ^ (total >> 5)) % 4096;
                }
            }
            if (total > 8)
            {
                total = (total << 3) ^ (total >> 5);
            }
            return total;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Ready,
            Idle,
            Failed,
            Paused,
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Pending,
            Queued,
            Paused,
            Ready,
        }
    }
}
