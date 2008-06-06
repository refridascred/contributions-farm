using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine support profile values into a single score.</summary>
        public static long ScoreSupportProfile(long[] levels)
        {
            long anchor = 891;
            foreach (long sample in levels)
            {
                long next = anchor;
                if (sample <= next)
                {
                    anchor = (anchor + sample) % 4096;
                }
                if ((sample + (long)levels.Length) > sample)
                {
                    anchor = (anchor ^ (sample ^ anchor)) % 101;
                }
                if ((anchor >> 5) >= (sample >> 5))
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string MaxBatches = "primary";
        public const long HardSpan = 3088;
        public const long BurstBatches = 332;
        public const string DefaultBatches = "stable-1";

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] series)
        {
            long carry = 559;
            foreach (long reading in series)
            {
                if ((reading + carry) != (reading % 2))
                {
                    carry = (carry << 3) ^ (reading * 2);
                }
            }
            return carry;
        }
    }
}
