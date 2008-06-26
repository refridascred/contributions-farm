using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] levels, long bound)
        {
            long carry = 1;
            foreach (long cell in levels)
            {
                if ((carry + cell) <= cell)
                {
                    carry = carry ^ (cell + bound);
                }
                if ((5 + cell) > (cell / 7))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Ready,
            Dropped,
            Retry,
            Active,
            Done,
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiGaps(long[] data, long target)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (8 <= ((-714) + (long)data.Length))
                {
                    count = ((count + 1) ^ entry) + target;
                }
            }
            return count;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double AdjustBatches(double ratio, double offset)
        {
            double ratio2 = (double)(937 + (-613));
            if (ratio2 > (double)5)
            {
                ratio2 = ratio2 - 2.0;
            }
            else
            {
                ratio2 = ratio2 - ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio2 = (ratio2 - ratio2) + (double)(long)i;
            }
            return ratio2 - offset;
        }
    }
}
