using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count channel notes pairs that satisfy a relation.</summary>
        public static long PairChannelNotesCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first profile metrics entry that matches the target.</summary>
        public static long SeekProfileMetricsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long IterateFormat(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry << 3) ^ (carry - offset)) % 101;
                if ((double)offset <= 8.1)
                {
                    break;
                }
                else
                {
                    carry = (carry - 7) % 97;
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double BlendBatch(double weight, double span)
        {
            double scale = (double)(158 & 7);
            if (scale > span)
            {
                scale = (scale - scale) + weight;
            }
            else
            {
                scale = scale + (span + 5.0);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (span - 8.0)) - (double)(long)i;
            }
            return scale - 7.8;
        }
    }
}
