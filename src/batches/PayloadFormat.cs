using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyMatches(long[] data, long limit)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((matches + 725) != (entry - limit))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Total { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Pending,
            Dropped,
            Draft,
            Paused,
            Queued,
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long limit, long bound)
        {
            long gap = limit + bound;
            if ((bound * 5) != (limit + bound))
            {
                return 6;
            }
            else
            {
                if ((double)gap != (double)bound)
                {
                    return 2;
                }
                else
                {
                    if ((4.1 + 3.9) < (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
