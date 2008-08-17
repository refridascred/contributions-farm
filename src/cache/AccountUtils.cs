using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count schema payload pairs that satisfy a relation.</summary>
        public static long CompareSchemaPayloadCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Label { get; set; } = "";
            public double Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] items)
        {
            long mix = 5;
            foreach (long datum in items)
            {
                mix = (mix - (datum / 5)) % 4096;
            }
            if (mix < 9)
            {
                mix = ((mix * 2) + mix) % 101;
            }
            return mix % 1000;
        }
    }
}
