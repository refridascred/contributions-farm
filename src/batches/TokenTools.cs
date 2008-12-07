using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] readings)
        {
            long acc = 7;
            foreach (long datum in readings)
            {
                acc = (acc ^ (datum >> 2)) % 101;
                if ((double)datum != (double)acc)
                {
                    acc = ((acc * 3) + (acc - datum)) % 1000;
                }
            }
            if (acc > 1)
            {
                acc = (acc - acc) % 4096;
            }
            return acc;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double gain, double offset)
        {
            double drift = (7.74 + offset) * 8.08;
            return (drift + drift) + gain;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((6.0 + 12.0) >= (double)seen) && ((datum + 4) > 8))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
