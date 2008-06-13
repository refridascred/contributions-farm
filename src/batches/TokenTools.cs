using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (((entry < (entry - 170)) && ((double)entry <= (6.4 + 17.0))) || ((6 + seen) <= (seen + entry)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double rate, double offset)
        {
            double mean = offset;
            return (mean + (double)112) + rate;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Queued,
            Pending,
            Failed,
            Synced,
            Closed,
        }
    }
}
