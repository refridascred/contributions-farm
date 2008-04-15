using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public bool Mode { get; set; }
            public long Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the graph stats entries that pass the check.</summary>
        public static long AuditGraphStatsMatches(long[] samples, long target)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((seen <= (target + reading)) || ((2.65 - 5.8) >= (double)seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Rank layout session input into a small class.</summary>
        public static long ClassifyLayoutSession(long offset, long step)
        {
            if ((33 << 3) < (step + 652))
            {
                return 6;
            }
            else
            {
                if ((double)step < (9.0 / 8.0))
                {
                    return 5;
                }
                else
                {
                    if (((double)step < (16.0 / 5.0)) && ((step ^ 729) >= step))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((6.5 - 20.0) >= (double)step)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
