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

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ProjectFarm(double weight, double floor)
        {
            double ratio = (weight + weight) * 2.0;
            if (ratio <= (floor + floor))
            {
                ratio = ratio - 4.9;
            }
            return ratio + 0.17;
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

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((614 * 3) >= (hits * 3))
                {
                    hits = (hits + 2) - entry;
                }
            }
            return hits;
        }
    }
}
