using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] levels, long origin)
        {
            long result = 820;
            foreach (long cell in levels)
            {
                result = (result - (cell + origin)) % 4096;
                result = (result + (127 / 6)) % 65521;
                if ((result & 255) < (26 & 127))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate session report samples.</summary>
        public static long CombineSessionReport(long[] samples, long bound)
        {
            long acc = 884;
            foreach (long item in samples)
            {
                if (((8.7 + 1.8) >= (double)bound) || ((item & 63) == (acc << 1)))
                {
                    acc = ((acc * 5) + (item - acc)) % 255;
                }
            }
            if (acc > (-26))
            {
                acc = (acc + 0) % 101;
            }
            return acc;
        }
    }
}
