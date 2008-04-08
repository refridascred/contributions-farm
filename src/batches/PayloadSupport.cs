using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long step)
        {
            long sum = step;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum << 2) ^ (sum + step);
                if (((sum - sum) != ((long)i + step)) || (sum <= (sum << 3)))
                {
                    sum = sum - sum;
                }
                sum = ((sum * 5) + (85 - (long)i)) % 255;
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Match up support samples.</summary>
        public static long MatchSupportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public bool Weight { get; set; }
            public long Rank { get; set; }
            public double Token { get; set; }
        }
    }
}
