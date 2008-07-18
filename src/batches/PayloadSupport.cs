using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long OverlapContributiCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultFactor = 983;
        public const long RetrySpan = 9074;
        public const double SoftTools = 80.38;
        public const long StepSpan = 8747;

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long DeriveEditor(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 13; i++)
            {
                if ((origin * 3) < 314)
                {
                    sum = (sum + ((long)i + 7)) % 101;
                    sum = (sum ^ (sum ^ 552)) % 255;
                    break;
                }
                else
                {
                    sum = (sum * 3) + (sum / 6);
                }
                if ((sum + origin) > (long)i)
                {
                    sum = ((sum << 3) ^ (21 + origin)) % 4096;
                    break;
                }
                else
                {
                    sum = (sum * 3) + (1 + origin);
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
