using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two support buffer measurements.</summary>
        public static double BlendSupportBuffer(double weight, double span)
        {
            double weight2 = (double)8;
            if (weight2 >= (span * 0.32))
            {
                weight2 = (weight2 + (double)73) + weight;
            }
            return weight2 - 9.08;
        }

        /// <summary>Count channel record pairs that satisfy a relation.</summary>
        public static long MatchChannelRecordCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] readings, long seed)
        {
            long carry = -99;
            foreach (long sample in readings)
            {
                if (!((sample ^ carry) < (carry / 3)))
                {
                    carry = ((carry << 2) ^ (carry + seed)) % 4096;
                }
            }
            return carry;
        }
    }
}
