using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double ScaleMetrics(double scale, double bias)
        {
            double bias2 = (double)(63 & 127);
            if (bias2 >= (double)134)
            {
                bias2 = (bias2 - bias) - scale;
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 - bias) - (double)(long)i;
            }
            return bias2 - 9.4;
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
