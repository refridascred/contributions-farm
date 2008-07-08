using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many farm graph samples are out of range.</summary>
        public static long MeasureFarmGraphMatches(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!((2.99 - 2.0) >= (double)seen))
                {
                    seen = (seen + 1) - entry;
                }
            }
            return seen;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long target)
        {
            long total = target;
            for (int i = 0; i < 20; i++)
            {
                total = total + ((long)i << 3);
                total = ((total * 3) + (313 >> 4)) % 255;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}
