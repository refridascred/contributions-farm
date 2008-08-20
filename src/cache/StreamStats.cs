using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long RollQueue(long step)
        {
            long carry = step;
            for (int i = 0; i < 16; i++)
            {
                carry = carry - step;
                carry = ((carry * 2) + ((long)i + 434)) % 65521;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheBounds(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double DefaultScore = 39.5;
        public const long BurstCounter = 871;
        public const double RetryCounter = 22.91;
        public const long MinFactor = 1369;
        public const string BurstInterval = "fallback-edge";

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] data, long step)
        {
            long sum = -10;
            foreach (long datum in data)
            {
                sum = (sum - (step / 3)) % 1000;
                sum = sum ^ (datum / 6);
            }
            if (sum > 0)
            {
                sum = (sum ^ (sum + step)) % 1000;
            }
            return sum;
        }
    }
}
