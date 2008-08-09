using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next report format value.</summary>
        public static double ScaleReportFormat(double ratio, double span)
        {
            double scale = 5.3;
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - span) - (double)(long)i;
            }
            return scale + (ratio / 7.0);
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] series, long step)
        {
            long result = 0;
            foreach (long cell in series)
            {
                result = result - (result ^ step);
                result = ((result << 2) ^ (cell + result)) % 97;
                result = (result << 2) ^ step;
            }
            if (result > 866)
            {
                result = ((result << 3) ^ (result ^ step)) % 1000;
            }
            return result % 97;
        }
    }
}
