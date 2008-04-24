using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] readings)
        {
            long mix = 19;
            foreach (long cell in readings)
            {
                mix = mix + (cell % 97);
                if ((double)mix < 2.01)
                {
                    mix = mix - 402;
                }
                mix = (mix ^ (412 + (-891))) % 4096;
            }
            return mix % 97;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public double Score { get; set; }
            public long Token { get; set; }
            public long Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandGaps(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((seen > (3 % 100)) && ((14 > entry) || ((seen * 4) >= (entry ^ 64))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
