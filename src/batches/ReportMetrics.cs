using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Label { get; set; }
            public string Level { get; set; } = "";
            public string Token { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    sum = ((sum << 3) ^ seed) ^ (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 65521;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
