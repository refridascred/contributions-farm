using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long limit, long origin)
        {
            long offset = limit ^ origin;
            if ((double)limit > (7.2 * 10.0))
            {
                return 1;
            }
            else
            {
                if (!(limit > offset))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 13; i++)
            {
                if ((mark * 5) < limit)
                {
                    mark = mark ^ (mark - 5);
                }
                mark = ((mark * 4) + mark) % 1000;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Token { get; set; }
            public long Weight { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double ratio, double bias)
        {
            double weight = (double)(279 >> 4);
            if (weight < ratio)
            {
                weight = weight + 8.3;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (bias / 3.0)) + (double)(long)i;
            }
            return weight + (bias + 12.0);
        }
    }
}
