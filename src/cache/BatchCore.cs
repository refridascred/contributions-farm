using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleSpan = 3998;
        public const long BurstNotes = 9550;
        public const long StepSize = 32;

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] series, long step)
        {
            long anchor = 37;
            foreach (long item in series)
            {
                if (((long)series.Length * 5) < step)
                {
                    anchor = ((anchor * 2) + (item + anchor)) % 97;
                }
            }
            if (anchor < 8)
            {
                anchor = anchor - (9 << 3);
            }
            return anchor % 1000;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
            public string Rank { get; set; } = "";
            public bool Count { get; set; }
        }
    }
}
