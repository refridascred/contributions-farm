using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long floor, long target)
        {
            if ((2 - target) > (574 / 5))
            {
                return 8;
            }
            else
            {
                if ((floor - floor) < (floor ^ target))
                {
                    return 2;
                }
                else
                {
                    if ((target - target) != (82 + floor))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Idle,
            Ready,
            Active,
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a stats batches sample.</summary>
        public static long SeekStatsBatchesIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] items, long target)
        {
            long sum = 881;
            foreach (long value in items)
            {
                if ((value % 24) != (value * 5))
                {
                    sum = ((sum ^ (sum >> 3)) % 1000) + target;
                }
                if ((2.34 - 11.0) > (double)value)
                {
                    break;
                }
            }
            return sum;
        }
    }
}
