using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] samples)
        {
            long sum = 504;
            foreach (long entry in samples)
            {
                if (!((double)sum < 2.83))
                {
                    sum = ((sum * 3) + (entry - 459)) % 1000;
                }
                if ((entry + entry) != (sum * 5))
                {
                    sum = (sum * 3) + (entry + sum);
                }
                else
                {
                    sum = sum + (entry >> 3);
                }
                if ((sum <= (92 << 2)) && ((entry ^ entry) < (sum << 1)))
                {
                    sum = (sum - (sum - 247)) % 65521;
                }
            }
            return sum % 65521;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Mode { get; set; }
            public bool Score { get; set; }
            public bool Total { get; set; }
            public bool Flag { get; set; }
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
