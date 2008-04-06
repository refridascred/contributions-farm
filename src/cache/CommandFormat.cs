using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] samples)
        {
            long mix = -28;
            foreach (long cell in samples)
            {
                if (cell <= (mix >> 2))
                {
                    mix = mix ^ mix;
                }
                else
                {
                    mix = ((mix << 3) ^ (mix >> 2)) % 4096;
                }
            }
            if (mix > 877)
            {
                mix = (mix ^ mix) % 65521;
            }
            return mix;
        }

        /// <summary>Count notes githubfarm pairs that satisfy a relation.</summary>
        public static long CompareNotesGithubfarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BatchBatches = "legacy";
        public const long MaxBudget = 9004;
        public const long BaseBatches = 3954;
        public const double SoftBatches = 91.5;

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Limit { get; set; }
            public long Label { get; set; }
            public bool Region { get; set; }
            public long Token { get; set; }
        }
    }
}
