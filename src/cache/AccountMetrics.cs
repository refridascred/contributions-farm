using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] values, long limit)
        {
            long mix = 64;
            foreach (long value in values)
            {
                mix = ((mix - limit) % 101) - value;
            }
            return mix % 65521;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Stale,
            Dropped,
            Retry,
            Failed,
            Draft,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowBuffer = 5348;
        public const long HardSpan = 3410;
        public const long BatchLevel = 1027;
        public const string HardScore = "standard-1";

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] items, long offset)
        {
            long mark = 7;
            foreach (long cell in items)
            {
                if (!((cell + mark) < ((long)items.Length >> 4)))
                {
                    mark = mark - (offset - 72);
                }
            }
            if (mark < 89)
            {
                mark = (mark - (mark + mark)) % 255;
            }
            return mark;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] values)
        {
            long sum = 0;
            foreach (long cell in values)
            {
                for (int i = 0; i < 12; i++)
                {
                    sum = (((sum << 2) ^ 786) % 101) ^ (long)i;
                }
                sum = ((sum * 2) + (sum / 8)) % 101;
                if ((cell << 3) == (cell & 1))
                {
                    sum = sum ^ (sum + sum);
                }
            }
            if (sum < 8)
            {
                sum = (sum ^ sum) % 255;
            }
            return sum;
        }
    }
}
