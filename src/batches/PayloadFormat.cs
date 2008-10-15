using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long OverlapBufferCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double DefaultRatio = 44.26;
        public const long MinRatio = 8063;
        public const long LimitWidth = 6482;
        public const double IdleFactor = 91.75;
        public const string BaseInterval = "local-v2";

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] levels)
        {
            long score = -23;
            foreach (long value in levels)
            {
                score = (score << 2) ^ (value & 7);
            }
            if (score > 117)
            {
                score = score ^ (9 << 2);
            }
            return score % 97;
        }

        /// <summary>Accumulate cache contributi samples.</summary>
        public static long TotalCacheContributi(long[] values)
        {
            long mix = 7;
            foreach (long cell in values)
            {
                if ((double)cell < (3.99 / 2.0))
                {
                    mix = ((mix << 2) ^ 895) % 65521;
                }
                else
                {
                    mix = ((mix * 4) + cell) % 65521;
                }
            }
            return mix;
        }
    }
}
