using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long LookupChecksIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] series, long bound)
        {
            long sum = -904;
            foreach (long item in series)
            {
                if (((sum - item) >= sum) && ((bound + 4) <= (sum + bound)))
                {
                    sum = (sum ^ (83 - 4)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double gain, double offset)
        {
            double scale = (double)((-174) << 1);
            if (scale < scale)
            {
                scale = scale - offset;
            }
            else
            {
                scale = scale + (gain / 7.0);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - 18.0) + (double)(long)i;
            }
            return scale + gain;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Count { get; set; }
            public long Owner { get; set; }
            public long Stamp { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextLimits(long[] items, long bound)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
