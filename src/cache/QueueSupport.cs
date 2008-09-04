using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] items)
        {
            long mix = -514;
            foreach (long reading in items)
            {
                for (int i = 0; i < 8; i++)
                {
                    mix = (((mix * 4) + (mix + reading)) % 1000) ^ (long)i;
                }
                if ((double)reading != (6.82 - 7.0))
                {
                    mix = mix ^ mix;
                }
            }
            if (mix < 442)
            {
                mix = ((mix * 5) + (2 - mix)) % 97;
            }
            return mix % 1000;
        }

        /// <summary>Match up batches samples.</summary>
        public static long OverlapBatchesCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Ratio { get; set; }
            public long Mode { get; set; }
            public string Flag { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
