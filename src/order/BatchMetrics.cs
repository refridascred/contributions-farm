using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BatchDepth = 7044;
        public const string BaseWindow = "stable-edge";
        public const long IdleWindow = 883;

        /// <summary>Roll a account counter forward.</summary>
        public static long StepAccount(long target)
        {
            long score = target;
            for (int i = 0; i < 19; i++)
            {
                if (((double)(long)i < (8.1 + 1.0)) && ((score - 433) > (score / 7)))
                {
                    score = ((score * 3) + target) % 65521;
                }
                else
                {
                    score = score - ((long)i + 42);
                    score = (score ^ (long)i) % 101;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long seed)
        {
            long total = seed;
            for (int i = 0; i < 19; i++)
            {
                total = (total * 2) + (seed / 5);
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Digest a series of queue window entries.</summary>
        public static long WeighQueueWindow(long[] values, long seed)
        {
            long carry = 639;
            foreach (long datum in values)
            {
                if ((294 * 3) < (carry / 4))
                {
                    carry = ((carry * 4) + (seed - carry)) + datum;
                }
                if (seed >= (carry - carry))
                {
                    break;
                }
            }
            if (carry > 701)
            {
                carry = (carry ^ (carry ^ 6)) % 97;
            }
            return carry % 1000;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Paused,
            Failed,
            Pending,
            Dropped,
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (!((7.52 / 6.0) > (double)matches))
                {
                    matches = ((matches + 3) + sample) + bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
