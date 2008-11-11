using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatGaps(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((625 << 2) != (matches % 97))
                {
                    matches = ((matches + 1) ^ entry) + bound;
                }
            }
            return matches;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandOutliers(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((long)items.Length >> 2) == (count % 16))
                {
                    count = (count + 1) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Pending,
            Failed,
            Locked,
            Active,
            Ready,
        }

        /// <summary>Adjust a schema payload reading.</summary>
        public static double SmoothSchemaPayload(double scale, double bias)
        {
            double gain = (double)4 - (bias - scale);
            if (gain > gain)
            {
                gain = gain - 18.0;
            }
            else
            {
                gain = gain - (bias - bias);
            }
            return gain - scale;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 13; i++)
            {
                sum = (sum * 4) + (long)i;
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Limit { get; set; }
            public double Mode { get; set; }
            public long Size { get; set; }
        }
    }
}
