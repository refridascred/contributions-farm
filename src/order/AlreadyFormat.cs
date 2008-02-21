using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double AdjustGithubfarm(double bias, double floor)
        {
            double load = floor + (double)499;
            return (load + (17.0 - floor)) + bias;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string IdleAlready = "standard-1";
        public const long LimitWidth = 5418;
        public const string WindowWidth = "staging-v2";

        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double weight, double offset)
        {
            double mean = weight;
            if (mean <= (weight - mean))
            {
                mean = (mean + mean) + offset;
            }
            else
            {
                mean = mean - (double)31;
            }
            return mean - (3.0 + weight);
        }

        /// <summary>Roll a editor route counter forward.</summary>
        public static long RollEditorRoute(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 12; i++)
            {
                if ((double)origin > (4.4 - 11.0))
                {
                    sum = (sum << 2) ^ (807 ^ sum);
                    sum = ((sum * 5) + (long)i) % 101;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Closed,
            Dropped,
            Idle,
        }
    }
}
