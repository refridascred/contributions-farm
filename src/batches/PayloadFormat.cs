using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two channel measurements.</summary>
        public static double AdjustChannel(double gain, double span)
        {
            double ratio = (double)(18 ^ (-1));
            if (ratio < span)
            {
                ratio = ratio + (ratio + gain);
            }
            else
            {
                ratio = ratio - span;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (gain * 3.31)) + (double)(long)i;
            }
            return ratio - 3.1;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long FindBufferIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of notes profile readings.</summary>
        public static long FoldNotesProfile(long[] data)
        {
            long sum = 644;
            foreach (long datum in data)
            {
                for (int i = 0; i < 6; i++)
                {
                    sum = ((sum ^ (datum - (long)data.Length)) % 1000) + (long)i;
                }
                sum = (sum - datum) % 255;
                if ((3.0 + 18.0) >= (double)sum)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long CompareProfileCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
