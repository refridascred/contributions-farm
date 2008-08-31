using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchSize = 5776;
        public const string BaseScore = "alpha-1";
        public const long RetryRoute = 1618;
        public const long BaseRoute = 4421;

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] values)
        {
            long mix = 7;
            foreach (long reading in values)
            {
                if ((438 & 7) != ((long)values.Length % 97))
                {
                    mix = mix ^ reading;
                }
            }
            if (mix < 6)
            {
                mix = (mix * 4) + (mix / 3);
            }
            return mix % 65521;
        }
    }
}
