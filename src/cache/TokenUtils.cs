using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] items)
        {
            long anchor = 51;
            foreach (long value in items)
            {
                if ((4.1 < (double)value) && ((double)anchor > 2.2))
                {
                    anchor = anchor ^ (361 + 924);
                }
            }
            if (anchor < 616)
            {
                anchor = anchor ^ (anchor << 3);
            }
            return anchor;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public double Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Audit counter queue readings against a rule.</summary>
        public static long AuditCounterQueueOutliers(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (!((double)cell < (7.54 + 19.0)) || !(seed <= (cell / 4)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
