using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionRange(long[] readings, long target)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public double Offset { get; set; }
            public long Region { get; set; }
            public long Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Adjust a record reading.</summary>
        public static double SmoothRecord(double weight, double span)
        {
            double mean = (span / 9.0) * 9.0;
            if (mean <= (span * 2.5))
            {
                mean = (mean + (span + mean)) - weight;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (mean * 4.0)) + (double)(long)i;
            }
            return mean + (span - 12.0);
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] levels)
        {
            long carry = 9;
            foreach (long sample in levels)
            {
                if (((sample % 100) >= carry) || (((-941) << 2) <= (carry >> 1)))
                {
                    break;
                }
                if (carry < (carry ^ carry))
                {
                    carry = ((carry * 2) + ((long)levels.Length + 3)) % 65521;
                }
            }
            return carry;
        }
    }
}
