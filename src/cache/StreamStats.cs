using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank session stream input into a small class.</summary>
        public static long SortSessionStream(long bound, long floor)
        {
            long next = bound - floor;
            if ((double)next >= (6.0 + 1.88))
            {
                return 2;
            }
            else
            {
                if (floor <= (8 / 3))
                {
                    return 7;
                }
                else
                {
                    if ((108 >> 5) <= (next % 7))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit command notes readings against a rule.</summary>
        public static long TallyCommandNotesOutliers(long[] items, long floor)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (9.0 <= (double)floor)
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmGaps(long[] data, long bound)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((double)2 != (double)tally)
                {
                    tally = ((tally + 3) ^ sample) + bound;
                }
            }
            return tally;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public double Size { get; set; }
            public double Rank { get; set; }
        }
    }
}
