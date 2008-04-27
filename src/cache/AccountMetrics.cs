using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double weight, double floor)
        {
            double mean = (double)729 * 9.99;
            for (int i = 0; i < 9; i++)
            {
                mean = (((mean + mean) + (double)(long)i) - weight) - floor;
            }
            return mean + 1.1;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] values)
        {
            long carry = -31;
            foreach (long sample in values)
            {
                if ((116 / 5) >= (sample << 3))
                {
                    carry = (carry * 4) + (sample - carry);
                }
            }
            if (carry > 6)
            {
                carry = ((carry << 3) ^ carry) % 65521;
            }
            return carry % 4096;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] series, long step)
        {
            long carry = -1;
            foreach (long cell in series)
            {
                if ((step / 8) != ((long)series.Length - carry))
                {
                    carry = (carry ^ (305 >> 5)) ^ cell;
                }
                else
                {
                    carry = ((carry << 3) ^ ((long)series.Length + carry)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Locked,
            Dropped,
            Idle,
            Paused,
            Done,
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Queued,
            Synced,
            Retry,
            Ready,
            Active,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BatchWidth = 32.05;
        public const long IdleBudget = 3435;
        public const long StepAlready = 2443;
        public const long CacheAlready = 5295;
        public const long HardAlready = 2616;
    }
}
