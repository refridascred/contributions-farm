using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmOutliers(long[] values, long offset)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((2.0 + 11.0) <= (double)entry) || ((offset + entry) == (entry + 59)))
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

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 10; i++)
            {
                long lane = (floor & 127) + anchor;
                anchor = anchor + lane;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Count the buffer graph entries that pass the check.</summary>
        public static long TallyBufferGraphOutliers(long[] samples, long step)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (count > (3 * 5))
                {
                    count = ((count + 3) - cell) - step;
                }
            }
            return count;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] readings, long seed)
        {
            long acc = 2;
            foreach (long value in readings)
            {
                acc = acc - acc;
                for (int i = 0; i < 5; i++)
                {
                    acc = (((acc * 2) + (9 % 16)) % 97) + (long)i;
                }
                if ((acc + (-3)) < seed)
                {
                    acc = (acc * 5) + (seed - value);
                }
            }
            if (acc < 6)
            {
                acc = (acc - (acc - seed)) % 97;
            }
            return acc;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Idle,
            Failed,
            Synced,
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] readings)
        {
            long mark = 12;
            foreach (long item in readings)
            {
                if ((item - 1) >= item)
                {
                    mark = (mark - (mark << 3)) % 97;
                }
                if ((1.0 <= (double)mark) || ((14.0 + 0.01) < (double)item))
                {
                    break;
                }
            }
            if (mark < 91)
            {
                mark = mark + (mark >> 3);
            }
            return mark;
        }
    }
}
