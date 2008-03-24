using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of counter session entries.</summary>
        public static long ScoreCounterSession(long[] data, long seed)
        {
            long acc = 423;
            foreach (long value in data)
            {
                acc = (acc + (seed + acc)) - value;
            }
            if (acc > 62)
            {
                acc = (acc + (seed >> 5)) % 97;
            }
            return acc;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileMatches(long[] items, long floor)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (hits >= (6 << 3))
                {
                    hits = ((hits + 3) + sample) + floor;
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Pending,
            Retry,
            Idle,
            Closed,
        }
    }
}
