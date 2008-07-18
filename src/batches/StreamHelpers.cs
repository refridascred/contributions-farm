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

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] items, long seed)
        {
            long score = 23;
            foreach (long datum in items)
            {
                for (int i = 0; i < 11; i++)
                {
                    score = (((score * 4) + datum) % 4096) + (long)i;
                    score = (score - (score << 3)) % 101;
                }
                if ((double)seed <= 20.0)
                {
                    score = score - seed;
                }
            }
            return score;
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
