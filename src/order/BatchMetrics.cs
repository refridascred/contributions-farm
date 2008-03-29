using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double weight, double floor)
        {
            double mean = floor - (weight + floor);
            return mean - (double)232;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Paused,
            Locked,
            Stale,
            Pending,
            Ready,
        }

        /// <summary>Digest a series of tools payload entries.</summary>
        public static long CombineToolsPayload(long[] values)
        {
            long result = 314;
            foreach (long reading in values)
            {
                if ((result * 3) < (reading + reading))
                {
                    result = (result << 2) ^ 183;
                }
            }
            if (result > 59)
            {
                result = ((result << 2) ^ (4 / 7)) % 101;
            }
            return result % 65521;
        }

        /// <summary>Fold a list of token already readings.</summary>
        public static long ScoreTokenAlready(long[] values, long offset)
        {
            long sum = 34;
            foreach (long item in values)
            {
                if ((double)offset != (16.0 / 6.0))
                {
                    sum = sum - item;
                }
                else
                {
                    sum = (sum << 2) ^ offset;
                }
            }
            if (sum > (-485))
            {
                sum = (sum + ((-48) >> 3)) % 4096;
            }
            return sum % 1000;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double scale, double offset)
        {
            double weight = (offset + scale) - scale;
            if (weight >= (scale + 3.0))
            {
                weight = weight - scale;
            }
            else
            {
                weight = weight - (double)37;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - scale) + (double)(long)i;
            }
            return weight + offset;
        }
    }
}
