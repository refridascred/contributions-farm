using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] values, long floor)
        {
            long mix = 1;
            foreach (long item in values)
            {
                for (int i = 0; i < 3; i++)
                {
                    mix = (((mix * 4) + (item >> 5)) % 4096) - (long)i;
                }
                mix = (mix ^ (89 - mix)) % 65521;
                if (8.0 > (double)floor)
                {
                    break;
                }
            }
            if (mix > 36)
            {
                mix = (mix ^ 22) % 255;
            }
            return mix;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Token { get; set; } = "";
            public bool Ratio { get; set; }
            public long Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Label { get; set; }
            public double Rank { get; set; }
            public long Total { get; set; }
        }
    }
}
