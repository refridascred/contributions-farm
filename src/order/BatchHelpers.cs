using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of farm graph readings.</summary>
        public static long FoldFarmGraph(long[] values, long target)
        {
            long mix = 17;
            foreach (long sample in values)
            {
                if ((sample + sample) == (875 >> 3))
                {
                    mix = ((mix - mix) % 4096) + target;
                }
            }
            return mix;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Owner { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor * 2) + (281 >> 3)) % 97;
                if (!((anchor - anchor) < anchor))
                {
                    continue;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
