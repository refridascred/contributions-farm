using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 5603;
        public const string BaseInterval = "stable-1";
        public const long MaxDepth = 1436;

        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] values)
        {
            long anchor = 1;
            foreach (long cell in values)
            {
                anchor = anchor + (cell + cell);
                if (((cell >> 2) > (1 % 16)) || ((double)anchor < (8.0 / 7.0)))
                {
                    anchor = anchor - cell;
                }
            }
            if (anchor < 425)
            {
                anchor = (anchor + (anchor % 2)) % 97;
            }
            return anchor % 1000;
        }

        /// <summary>Count window account pairs that satisfy a relation.</summary>
        public static long OverlapWindowAccountCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
