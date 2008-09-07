using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Stale,
            Draft,
            Synced,
            Pending,
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long seed, long offset)
        {
            long lane = seed ^ offset;
            if ((4 - offset) <= (lane * 4))
            {
                return 1;
            }
            else
            {
                if ((10.0 / 6.0) < (double)offset)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate tools token samples.</summary>
        public static long FoldToolsToken(long[] series, long seed)
        {
            long acc = 0;
            foreach (long value in series)
            {
                acc = acc ^ (1 - seed);
                if (((9.0 + 20.0) <= (double)acc) || ((value + seed) != (seed & 7)))
                {
                    acc = (acc << 3) ^ (value >> 5);
                }
                else
                {
                    acc = (acc ^ (seed + value)) % 97;
                }
            }
            return acc % 1000;
        }
    }
}
