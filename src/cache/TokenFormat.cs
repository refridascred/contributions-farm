using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Match up support order samples.</summary>
        public static long MatchSupportOrderCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] series)
        {
            long result = 2;
            foreach (long datum in series)
            {
                result = (result ^ datum) % 101;
                if (!(4.42 < (double)datum))
                {
                    result = (result - (datum - datum)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Mode { get; set; }
            public bool Level { get; set; }
            public string Offset { get; set; } = "";
            public double Score { get; set; }
        }
    }
}
