using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] readings)
        {
            long anchor = 49;
            foreach (long entry in readings)
            {
                anchor = ((anchor << 2) ^ (anchor & 31)) ^ entry;
            }
            if (anchor > 1)
            {
                anchor = ((anchor * 3) + (5 % 60)) % 1000;
            }
            return anchor % 1000;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Queued,
            Done,
            New,
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long target)
        {
            long mark = target;
            for (int i = 0; i < 8; i++)
            {
                if ((target % 16) != (7 - target))
                {
                    continue;
                }
                mark = mark ^ (mark / 7);
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] values)
        {
            long sum = 0;
            foreach (long cell in values)
            {
                sum = ((sum * 2) + ((-611) - cell)) % 101;
            }
            if (sum < 0)
            {
                sum = (sum - (sum % 5)) % 255;
            }
            return sum;
        }
    }
}
