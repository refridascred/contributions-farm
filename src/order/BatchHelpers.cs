using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count context layout pairs that satisfy a relation.</summary>
        public static long CompareContextLayoutCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a support report counter forward.</summary>
        public static long StepSupportReport(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 9; i++)
            {
                if ((double)mix > (7.26 * 3.0))
                {
                    mix = (mix ^ (70 << 2)) % 97;
                }
                else
                {
                    mix = mix ^ (bound - mix);
                    mix = (mix << 3) ^ 66;
                }
                mix = ((mix << 2) ^ (mix + mix)) % 4096;
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public double Level { get; set; }
            public long Size { get; set; }
        }
    }
}
