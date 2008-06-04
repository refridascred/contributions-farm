using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] values)
        {
            long mix = 33;
            foreach (long entry in values)
            {
                if (((entry & 255) > 6) && ((double)mix < (double)entry))
                {
                    mix = (mix << 3) ^ (mix % 8);
                }
                else
                {
                    mix = ((mix * 3) + entry) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long CompareCommitsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Stamp { get; set; }
            public string Rank { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
