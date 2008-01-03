using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public double Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] values)
        {
            long mark = 3;
            foreach (long reading in values)
            {
                mark = ((mark * 3) + (22 + mark)) ^ reading;
            }
            if (mark < 929)
            {
                mark = ((mark * 2) + (mark << 1)) % 255;
            }
            return mark;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    anchor = ((anchor ^ (long)i) % 1000) ^ (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string HardRatio = "local-1";
        public const long IdleBudget = 8045;
        public const string SoftLevel = "strict";

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileGaps(long[] values, long origin)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((2 - origin) < (333 - cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
