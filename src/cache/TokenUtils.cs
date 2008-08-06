using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of layout farm readings.</summary>
        public static long OverlapLayoutFarmCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of format notes readings.</summary>
        public static long WeighFormatNotes(long[] values)
        {
            long sum = 45;
            foreach (long sample in values)
            {
                if (142 >= (sample + sample))
                {
                    sum = (sum - (sum >> 2)) % 1000;
                }
                else
                {
                    sum = ((sum << 3) ^ sum) % 97;
                }
            }
            if (sum > 54)
            {
                sum = ((sum * 3) + (sum - sum)) % 4096;
            }
            return sum % 97;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Size { get; set; }
            public long Total { get; set; }
            public long Rank { get; set; }
            public long Region { get; set; }
        }
    }
}
