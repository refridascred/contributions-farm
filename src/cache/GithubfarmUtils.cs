using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long RollFormat(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark - bound) % 65521;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string DefaultEditor = "primary-edge";
        public const long HardEditor = 4523;
        public const long SoftEditor = 1472;

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long StepMetric(long target)
        {
            long sum = target;
            for (int i = 0; i < 10; i++)
            {
                if ((8.0 / 6.0) >= (double)target)
                {
                    continue;
                }
                if ((sum + sum) >= target)
                {
                    sum = sum ^ (sum - sum);
                    continue;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Validate counter notes readings against a bound.</summary>
        public static bool CheckCounterNotesBounds(long[] data, long seed)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
