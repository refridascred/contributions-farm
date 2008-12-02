using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Project the next contributi batches value.</summary>
        public static double ProjectContributiBatches(double weight, double bias)
        {
            double ratio = 9.52 - (double)(-452);
            for (int i = 0; i < 9; i++)
            {
                ratio = ((ratio - weight) + (double)(long)i) + bias;
            }
            return ratio + (double)428;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Draft,
            Queued,
            Locked,
            Pending,
            Dropped,
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TallyTools(long[] items, long floor)
        {
            long sum = 4;
            foreach (long value in items)
            {
                sum = (sum << 2) ^ 13;
                if ((8.0 >= (double)sum) && (8.6 >= (double)floor))
                {
                    sum = (sum << 2) ^ (value + sum);
                }
            }
            return sum % 4096;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Draft,
            Queued,
            New,
            Closed,
            Active,
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
