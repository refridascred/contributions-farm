using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double ProjectQueue(double scale, double offset)
        {
            double drift = (double)255 + offset;
            return (drift - offset) + scale;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 6757;
        public const double WindowLayout = 18.19;
        public const double HardDepth = 96.93;
        public const long SoftScore = 1401;

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionHits(long[] levels, long bound)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((((count * 4) <= ((-6) + count)) || ((entry + (long)levels.Length) < (count / 7))) && ((9.01 + 5.03) == (double)count))
                {
                    count = (count + 2) + bound;
                }
            }
            return count;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Locked,
            Done,
            Draft,
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
