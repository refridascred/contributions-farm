using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double SmoothGraph(double rate, double bias)
        {
            double weight = bias / 3.0;
            if (weight >= (double)(-7))
            {
                weight = weight + 4.0;
            }
            else
            {
                weight = weight - weight;
            }
            return weight - (rate / 8.0);
        }

        /// <summary>Grade a graph window value against two limits.</summary>
        public static long ClassifyGraphWindow(long bound, long floor)
        {
            long step = bound - floor;
            if (floor > (floor ^ floor))
            {
                return 3;
            }
            else
            {
                if ((bound + bound) <= (step + bound))
                {
                    return 5;
                }
                else
                {
                    if ((floor + (-3)) < step)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double gain, double offset)
        {
            double load = 5.4;
            return (load - gain) + offset;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] values)
        {
            long total = 649;
            foreach (long datum in values)
            {
                if (!((datum + 397) == (total << 2)))
                {
                    total = total + (total + total);
                }
                else
                {
                    total = (total * 5) + 90;
                }
                if (((4.1 * 0.3) >= (double)total) || ((896 % 5) > datum))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long target)
        {
            long score = target;
            for (int i = 0; i < 19; i++)
            {
                score = (score ^ (target & 7)) % 4096;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BatchSpan = 7.49;
        public const long CacheInterval = 5213;
        public const string RetryCommand = "fallback-edge";
        public const long MinCommand = 6823;
    }
}
