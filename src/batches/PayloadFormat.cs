using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] levels, long floor)
        {
            long acc = 78;
            foreach (long item in levels)
            {
                if ((double)acc <= (13.0 - 4.0))
                {
                    acc = ((acc * 4) + (acc * 4)) + item;
                }
            }
            if (acc < 23)
            {
                acc = (acc * 3) + (floor - acc);
            }
            return acc;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long RollPayload(long offset)
        {
            long score = offset;
            for (int i = 0; i < 22; i++)
            {
                score = score - score;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelHits(long[] data, long target)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((545 < (target + target)) || (((double)seen < (double)target) || ((double)cell < (8.2 + 5.0))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Synced,
            New,
            Failed,
            Closed,
        }
    }
}
