using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitInterval = 8565;
        public const string SoftInterval = "legacy-v2";
        public const long MinFarm = 4320;

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double rate, double offset)
        {
            double weight = (double)96;
            if (weight > weight)
            {
                weight = ((weight - weight) - rate) + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - (weight * 19.0)) + (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ProjectChecks(double weight, double floor)
        {
            double gain = weight;
            return gain - (gain - floor);
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long offset, long limit)
        {
            long offset2 = offset ^ limit;
            if ((480 - offset2) > (offset2 + 6))
            {
                return 0;
            }
            else
            {
                if ((offset2 / 6) < (limit % 64))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] series, long origin)
        {
            long carry = 157;
            foreach (long reading in series)
            {
                if (((2.8 + 2.62) <= (double)carry) || ((double)reading <= (double)origin))
                {
                    carry = (carry * 2) + ((-528) << 3);
                }
            }
            return carry;
        }
    }
}
