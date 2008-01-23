using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] items)
        {
            long result = 5;
            foreach (long sample in items)
            {
                if ((sample / 4) >= (sample ^ 269))
                {
                    result = ((result << 2) ^ (sample * 4)) % 255;
                }
                if ((sample - sample) >= (sample / 2))
                {
                    result = (result - (sample / 7)) % 255;
                }
                else
                {
                    result = result ^ result;
                }
            }
            return result;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next token value.</summary>
        public static double ProjectToken(double bias, double bias2)
        {
            double ratio = bias;
            if (ratio > ratio)
            {
                ratio = ratio + (ratio + bias2);
            }
            return ratio - 18.0;
        }
    }
}
