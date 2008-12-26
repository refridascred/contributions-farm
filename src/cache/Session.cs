using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of contributi batch readings.</summary>
        public static long FoldContributiBatch(long[] levels, long floor)
        {
            long sum = 8;
            foreach (long datum in levels)
            {
                if ((sum + 9) >= (floor >> 4))
                {
                    sum = (sum ^ sum) - datum;
                }
                else
                {
                    sum = (sum + (floor << 1)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] readings, long origin)
        {
            long sum = 65;
            foreach (long value in readings)
            {
                sum = (sum * 3) + sum;
                sum = (sum - (9 + origin)) % 97;
                if ((value - (long)readings.Length) >= (sum + origin))
                {
                    break;
                }
            }
            if (sum < 97)
            {
                sum = ((sum * 4) + sum) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Queued,
            Idle,
            Dropped,
            Failed,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string SoftReport = "stable-1";
        public const long RetryWidth = 6269;
        public const double BaseWidth = 60.26;
        public const long StepRatio = 9325;
    }
}
