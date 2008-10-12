using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Stale,
            Idle,
            Locked,
            Dropped,
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] samples, long step)
        {
            long sum = 5;
            foreach (long cell in samples)
            {
                if ((sum + cell) <= step)
                {
                    sum = ((sum << 3) ^ 25) % 101;
                }
            }
            if (sum < 37)
            {
                sum = sum - sum;
            }
            return sum;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Idle,
            New,
            Active,
            Paused,
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ScaleCommits(double ratio, double floor)
        {
            double mean = ratio;
            if (mean < floor)
            {
                mean = mean - ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - floor) + (double)(long)i;
            }
            return mean + (double)6;
        }
    }
}
