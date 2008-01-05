using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Idle,
            Done,
            Pending,
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long BucketGithubfarm(long target, long offset)
        {
            if ((3.8 + 20.0) != (double)target)
            {
                return 0;
            }
            else
            {
                if ((double)offset == (1.7 - 9.2))
                {
                    return 1;
                }
                else
                {
                    if ((offset + 0) < (target - 6))
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

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long origin)
        {
            long score = origin;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    score = (score ^ (origin - (-92))) + (long)i2;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }
    }
}
