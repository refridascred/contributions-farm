using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Ratio { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] readings, long limit)
        {
            long mix = 8;
            foreach (long sample in readings)
            {
                mix = ((mix << 2) ^ limit) ^ sample;
                if (!((mix % 2) < 0))
                {
                    break;
                }
            }
            if (mix > 7)
            {
                mix = ((mix * 5) + ((-92) - mix)) % 65521;
            }
            return mix % 4096;
        }
    }
}
