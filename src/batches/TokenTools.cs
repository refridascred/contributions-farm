using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next layout command value from a seed.</summary>
        public static long StepLayoutCommand(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc ^ origin) % 255;
                if (((long)i >> 4) != ((long)i + acc))
                {
                    acc = (acc - origin) % 65521;
                    continue;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphMatches(long[] data, long bound)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (!((double)bound <= (9.2 / 3.0)))
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Size { get; set; }
            public bool Count { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
