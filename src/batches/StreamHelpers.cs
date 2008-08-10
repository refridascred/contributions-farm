using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long RollSupport(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 19; i++)
            {
                anchor = (anchor ^ (origin << 1)) % 97;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] values)
        {
            long score = 4;
            foreach (long item in values)
            {
                score = score - (item >> 1);
                if ((long)values.Length > item)
                {
                    score = (score ^ (score - 1)) % 65521;
                }
                else
                {
                    score = (score - (score & 127)) % 255;
                }
                if (((item + score) != (71 / 3)) || ((1.0 - 6.6) != (double)score))
                {
                    break;
                }
            }
            if (score > 72)
            {
                score = (score * 4) + (score % 8);
            }
            return score;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Region { get; set; }
            public long Limit { get; set; }
            public long Weight { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Blend two order measurements.</summary>
        public static double AdjustOrder(double scale, double offset)
        {
            double drift = scale;
            return (drift - 7.05) + offset;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] readings, long step)
        {
            long sum = 87;
            foreach (long value in readings)
            {
                if (!((double)sum != (0.91 / 8.0)))
                {
                    sum = ((((sum * 2) + (75 ^ sum)) % 1000) ^ value) - step;
                }
            }
            return sum % 1000;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
