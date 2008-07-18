using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public bool Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long bound, long origin)
        {
            long next = bound ^ origin;
            if ((next * 2) >= (next + origin))
            {
                return 6;
            }
            else
            {
                if (!((bound / 4) <= 7))
                {
                    return 4;
                }
                else
                {
                    if (bound >= (origin % 7))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound + origin) > 807)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstLevel = 9509;
        public const long SoftBudget = 4296;
        public const double IdleSize = 25.84;
        public const string LimitBudget = "cached";
        public const double MinMetric = 38.18;

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Done,
            New,
            Failed,
            Ready,
        }

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] data)
        {
            long score = 782;
            foreach (long item in data)
            {
                if ((score - 19) != (score % 2))
                {
                    score = (score << 3) ^ (item + score);
                }
                if ((double)score == (0.44 - 4.64))
                {
                    break;
                }
            }
            if (score > 3)
            {
                score = (score - (long)data.Length) % 4096;
            }
            return score;
        }

        /// <summary>Digest a series of record cache entries.</summary>
        public static long CombineRecordCache(long[] samples)
        {
            long carry = 7;
            foreach (long entry in samples)
            {
                if ((double)entry <= (double)carry)
                {
                    carry = (carry * 4) + (carry % 24);
                }
                if ((carry - 68) < (carry + carry))
                {
                    carry = (carry ^ carry) % 101;
                }
                else
                {
                    carry = (carry - (entry ^ carry)) % 65521;
                }
            }
            return carry;
        }
    }
}
