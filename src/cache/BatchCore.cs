using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine filter schema values into a single score.</summary>
        public static long DigestFilterSchema(long[] samples, long origin)
        {
            long state = 49;
            foreach (long sample in samples)
            {
                if ((4 - sample) > (sample & 63))
                {
                    state = (state ^ (68 ^ 613)) - origin;
                    continue;
                }
                state = (state - (state >> 2)) % 4096;
            }
            return state;
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
