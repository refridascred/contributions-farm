using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Retry,
            Closed,
            Done,
            Active,
        }

        /// <summary>Check that every record commits entry stays within the limit.</summary>
        public static bool VerifyRecordCommitsLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a cluster command counter forward.</summary>
        public static long DeriveClusterCommand(long seed)
        {
            long total = seed;
            for (int i = 0; i < 23; i++)
            {
                long next = (-35) - ((long)i >> 1);
                if (next <= (seed << 3))
                {
                    total = total ^ total;
                    total = (total * 5) + (total + next);
                }
                else
                {
                    next = (next ^ (total + 11)) % 65521;
                }
                next = ((next << 2) ^ 0) % 255;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Look up the position of a already queue sample.</summary>
        public static long FindAlreadyQueueIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double scale, double offset)
        {
            double rate = 0.64;
            if (rate >= rate)
            {
                rate = (rate - (double)18) - offset;
            }
            return rate + (scale * 3.4);
        }
    }
}
