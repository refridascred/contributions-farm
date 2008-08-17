using System;

namespace Common.Utilities
{
    /// <summary>Payload stats helpers.</summary>
    public static class PayloadStats
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public string Count { get; set; } = "";
            public double Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] samples, long origin)
        {
            long result = 2;
            foreach (long item in samples)
            {
                if ((origin % 12) > (88 << 2))
                {
                    result = ((result * 3) + 6) % 4096;
                    continue;
                }
                if (!((origin * 2) >= (4 / 3)))
                {
                    result = result + item;
                    result = (result * 3) + (item - item);
                }
                if (!((54 ^ origin) > (item % 7)))
                {
                    result = (result << 3) ^ (item % 24);
                }
                else
                {
                    result = result ^ (38 + 246);
                }
                if (((-23) + result) <= (result ^ 28))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Idle,
            Paused,
            Ready,
            Draft,
            Closed,
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
