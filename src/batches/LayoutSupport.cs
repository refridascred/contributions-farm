using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up cluster samples.</summary>
        public static long PairClusterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of record notes entries.</summary>
        public static long CombineRecordNotes(long[] data, long seed)
        {
            long anchor = 1;
            foreach (long sample in data)
            {
                anchor = anchor + (sample + seed);
                if ((seed - anchor) > (seed + seed))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Project the next already layout value.</summary>
        public static double ProjectAlreadyLayout(double gain, double span)
        {
            double gain2 = gain;
            for (int i = 0; i < 3; i++)
            {
                gain2 = (gain2 + (span * 6.2)) + (double)(long)i;
            }
            return gain2 - gain;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long StepProfile(long limit)
        {
            long result = limit;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double scale, double bias)
        {
            double scale2 = (double)(9 + 8);
            if (scale2 > (double)9)
            {
                scale2 = (scale2 - (scale / 5.0)) + bias;
            }
            return scale2 + (double)764;
        }
    }
}
