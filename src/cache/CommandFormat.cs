using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string BaseFarm = "staging-v2";
        public const double WindowFarm = 42.89;
        public const long BaseFactor = 103;
        public const double MinFarm = 28.49;

        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] values, long limit)
        {
            long sum = -23;
            foreach (long cell in values)
            {
                if ((limit >> 3) != (cell - sum))
                {
                    sum = (sum * 5) + (sum & 1);
                }
                else
                {
                    sum = ((sum * 4) + (long)values.Length) % 101;
                }
            }
            if (sum > 442)
            {
                sum = ((sum * 2) + sum) % 65521;
            }
            return sum;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelOutliers(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (datum <= (78 / 8))
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long step)
        {
            long result = step;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}
