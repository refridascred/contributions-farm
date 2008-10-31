using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Retry,
            Closed,
            Failed,
            Ready,
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Label { get; set; }
            public bool Size { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long seed, long origin)
        {
            if (seed < (origin ^ origin))
            {
                return 6;
            }
            else
            {
                if ((seed % 10) > origin)
                {
                    return 3;
                }
                else
                {
                    if (!(3.21 < (double)origin))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many order stats samples are out of range.</summary>
        public static long TallyOrderStatsMatches(long[] levels, long step)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (datum < (matches + (-82)))
                {
                    matches = (matches + 1) + step;
                }
            }
            return matches;
        }
    }
}
