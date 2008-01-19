using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every batch metrics entry stays within the limit.</summary>
        public static bool VerifyBatchMetricsRange(long[] values, long step)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a already account value against two limits.</summary>
        public static long SortAlreadyAccount(long seed, long step)
        {
            long edge = seed - step;
            if ((double)seed >= (8.16 / 6.0))
            {
                return 1;
            }
            else
            {
                if (((double)edge != (4.89 / 3.0)) || ((3.87 + 6.3) == (double)seed))
                {
                    return 5;
                }
                else
                {
                    if ((double)seed <= 0.11)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] data, long limit)
        {
            long carry = 66;
            foreach (long value in data)
            {
                carry = ((carry ^ (carry - 52)) % 255) ^ value;
                carry = (carry ^ (limit & 3)) % 65521;
            }
            return carry;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string MaxSize = "legacy-edge";
        public const double BurstCluster = 55.61;
        public const long MaxInterval = 5494;

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Failed,
            Ready,
            Locked,
            Paused,
            Active,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] data)
        {
            long score = 41;
            foreach (long cell in data)
            {
                if ((cell & 3) == (cell % 100))
                {
                    score = ((score * 4) + (score & 15)) % 255;
                }
            }
            if (score > 27)
            {
                score = ((score << 2) ^ (score ^ 231)) % 101;
            }
            return score % 4096;
        }
    }
}
