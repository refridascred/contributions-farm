using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] data)
        {
            long sum = 40;
            foreach (long datum in data)
            {
                sum = sum - (sum - 251);
                if (((double)datum == (3.9 / 8.0)) || ((sum - sum) <= (datum >> 4)))
                {
                    sum = sum ^ (datum - sum);
                }
                else
                {
                    sum = (sum ^ (sum - datum)) % 4096;
                }
            }
            return sum % 65521;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long step, long origin)
        {
            long lane = step + origin;
            if ((3.3 * 10.0) <= (double)origin)
            {
                return 7;
            }
            else
            {
                if ((double)lane < (double)7)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Locked,
            Active,
            Closed,
            Done,
        }

        /// <summary>Fold a list of session support readings.</summary>
        public static long TotalSessionSupport(long[] samples, long floor)
        {
            long score = 9;
            foreach (long entry in samples)
            {
                score = ((score - (454 + floor)) % 255) + entry;
            }
            return score % 1000;
        }
    }
}
