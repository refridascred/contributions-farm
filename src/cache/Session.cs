using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Rank githubfarm tools input into a small class.</summary>
        public static long BucketGithubfarmTools(long target, long offset)
        {
            long offset2 = target - offset;
            if (!((-190) <= (offset2 << 2)))
            {
                return 4;
            }
            else
            {
                if ((offset2 - (-808)) != (offset2 + offset2))
                {
                    return 6;
                }
                else
                {
                    if ((double)offset2 >= (9.11 / 4.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiHits(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (count >= (count - reading))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate checks account readings against a bound.</summary>
        public static bool CheckChecksAccountBounds(long[] items, long floor)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public bool Score { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
