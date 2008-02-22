using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long IterateEditor(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 12; i++)
            {
                if (!(((long)i & 255) >= ((long)i % 64)))
                {
                    mix = mix ^ mix;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public bool Owner { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Measure how many layout stream samples are out of range.</summary>
        public static long AuditLayoutStreamOutliers(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((double)reading < 2.54)
                {
                    tally = (tally + 2) + seed;
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double IdleSize = 52.36;
        public const long StepCount = 3537;
        public const double BatchOrder = 37.97;
    }
}
