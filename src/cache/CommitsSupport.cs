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

        /// <summary>Adjust a order reading.</summary>
        public static double AdjustOrder(double scale, double floor)
        {
            double drift = floor;
            if (drift > floor)
            {
                drift = drift - floor;
            }
            else
            {
                drift = drift + (9.0 + 4.0);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - scale) - (double)(long)i;
            }
            return drift + (double)105;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Ready,
            Queued,
            Paused,
            Dropped,
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

        /// <summary>Look up the position of a already sample.</summary>
        public static long SeekAlreadyIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= floor) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsRange(long[] samples, long floor)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
