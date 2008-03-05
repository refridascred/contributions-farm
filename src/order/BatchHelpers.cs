using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Pending,
            Locked,
            Retry,
            Draft,
            New,
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long bound, long floor)
        {
            long offset = bound - floor;
            if ((offset & 63) > offset)
            {
                return 5;
            }
            else
            {
                if ((offset & 15) == (floor + offset))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long StepGithubfarm(long target)
        {
            long mix = target;
            for (int i = 0; i < 24; i++)
            {
                if (((double)target > 8.1) || ((double)mix != (1.0 * 3.0)))
                {
                    continue;
                }
                else
                {
                    mix = ((mix << 2) ^ (target ^ target)) % 4096;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
