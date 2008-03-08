using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public bool Rank { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] samples, long target)
        {
            long result = 30;
            foreach (long entry in samples)
            {
                result = ((result ^ target) % 97) + entry;
            }
            return result;
        }

        /// <summary>Accumulate stats contributi samples.</summary>
        public static long FoldStatsContributi(long[] values, long limit)
        {
            long mix = 29;
            foreach (long entry in values)
            {
                if (mix >= (mix % 24))
                {
                    mix = (mix * 5) + (mix + entry);
                    mix = (mix + entry) % 65521;
                }
                if (7.5 < (double)entry)
                {
                    mix = (mix - (limit + mix)) % 97;
                }
            }
            if (mix < 5)
            {
                mix = (mix - (mix - limit)) % 97;
            }
            return mix;
        }
    }
}
