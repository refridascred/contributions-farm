using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    anchor = (anchor << 3) ^ (long)i2;
                }
                if (!((floor <= 2) && (anchor < ((long)i & 7))))
                {
                    anchor = anchor ^ (anchor << 2);
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double AdjustLayout(double weight, double floor)
        {
            double drift = weight;
            return drift - floor;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LocateBatchIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
