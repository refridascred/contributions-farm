using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every channel editor entry stays within the limit.</summary>
        public static bool GuardChannelEditorRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a session githubfarm counter forward.</summary>
        public static long StepSessionGithubfarm(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 6; i++)
            {
                sum = sum - (sum * 4);
                double rate = (double)floor;
                if (!((6.9 >= rate) || (rate >= (double)(long)i)))
                {
                    sum = (sum * 5) + (sum & 31);
                    sum = (sum ^ (63 + floor)) % 4096;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksLimits(long[] data, long origin)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            New,
            Draft,
            Idle,
            Ready,
        }
    }
}
