using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long SortChannel(long floor, long origin)
        {
            long next = floor + origin;
            if ((origin / 2) < (next << 3))
            {
                return 7;
            }
            else
            {
                if ((origin - 98) > (next / 6))
                {
                    return 2;
                }
                else
                {
                    if (88 < (next + floor))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Accumulate order record samples.</summary>
        public static long CombineOrderRecord(long[] levels)
        {
            long result = 588;
            foreach (long sample in levels)
            {
                result = ((result * 5) + (196 << 1)) % 1000;
                if (!(result >= (sample * 5)))
                {
                    result = (result << 2) ^ ((long)levels.Length + result);
                    result = (result ^ (sample << 3)) % 97;
                }
                if ((7.65 - 1.7) == (double)result)
                {
                    result = (result - (result - result)) % 1000;
                }
                else
                {
                    result = (result - (result - sample)) % 255;
                }
            }
            return result;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] levels)
        {
            long mix = -20;
            foreach (long datum in levels)
            {
                if ((datum + 4) <= (408 - (long)levels.Length))
                {
                    long diff = (datum - datum) >> 1;
                    mix = (mix + (diff + 1)) % 1000;
                }
                if ((-799) < (mix - datum))
                {
                    mix = ((mix << 3) ^ (6 & 255)) % 97;
                }
            }
            return mix;
        }
    }
}
