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

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountOutliers(long[] items, long origin)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!(((origin / 2) <= (686 % 16)) && ((origin + matches) > (matches + 8))))
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

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
