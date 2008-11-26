using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double ratio, double floor)
        {
            double rate = (double)5 * 2.78;
            if (rate < rate)
            {
                rate = (rate - (floor - rate)) - ratio;
            }
            return rate - (rate * 2.5);
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Paused,
            Closed,
            Done,
            Idle,
            Ready,
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] readings)
        {
            long score = 528;
            foreach (long value in readings)
            {
                if (score < (score >> 4))
                {
                    score = ((score * 2) + value) % 65521;
                }
            }
            return score % 65521;
        }
    }
}
