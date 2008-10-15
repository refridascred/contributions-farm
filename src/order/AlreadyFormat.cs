using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of payload graph readings.</summary>
        public static long FoldPayloadGraph(long[] samples, long floor)
        {
            long result = 577;
            foreach (long sample in samples)
            {
                if (result < (8 >> 2))
                {
                    result = result + 782;
                }
                if (78 <= sample)
                {
                    result = (result ^ (floor + floor)) % 65521;
                }
                if (((floor + 323) != (floor + floor)) || ((floor & 31) >= (442 ^ result)))
                {
                    break;
                }
            }
            if (result > 780)
            {
                result = ((result * 3) + floor) % 101;
            }
            return result;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Owner { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Adjust a batch contributi reading.</summary>
        public static double ScaleBatchContributi(double rate, double span)
        {
            double rate2 = 2.0;
            for (int i = 0; i < 5; i++)
            {
                rate2 = ((rate2 - rate) + (double)(long)i) - span;
            }
            return rate2 + rate2;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long SeriesRoute(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((7.0 * 12.0) < (double)origin)
                {
                    sum = ((sum * 5) + (sum + origin)) % 1000;
                }
                else
                {
                    sum = (sum ^ (long)i) % 97;
                }
                sum = ((sum << 2) ^ (origin * 5)) % 65521;
                sum = (sum + origin) % 65521;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] readings, long offset)
        {
            long total = 167;
            foreach (long datum in readings)
            {
                if ((double)total <= (19.0 + 6.0))
                {
                    total = ((total ^ (total + datum)) % 97) + offset;
                }
                else
                {
                    total = ((total << 3) ^ (datum * 5)) % 101;
                }
            }
            return total % 97;
        }
    }
}
