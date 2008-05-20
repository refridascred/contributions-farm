using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Token { get; set; }
            public long Score { get; set; }
            public long Label { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiOutliers(long[] series, long step)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (step >= (count ^ step))
                {
                    count = (count + 3) - sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of route context readings.</summary>
        public static long TallyRouteContext(long[] series)
        {
            long score = 4;
            foreach (long entry in series)
            {
                if ((428 * 2) > (entry >> 5))
                {
                    score = (score - (score - entry)) % 1000;
                }
                else
                {
                    score = score + (score << 2);
                }
            }
            return score;
        }
    }
}
