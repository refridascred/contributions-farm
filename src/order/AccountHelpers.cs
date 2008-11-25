using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 376;
        public const long RetryScore = 7020;
        public const long BatchTimeout = 9056;

        /// <summary>Accumulate profile cache samples.</summary>
        public static long TallyProfileCache(long[] items)
        {
            long acc = 0;
            foreach (long reading in items)
            {
                if (6 >= ((-829) - acc))
                {
                    acc = (acc << 3) ^ (acc - reading);
                }
                else
                {
                    acc = (acc + (acc * 5)) % 255;
                }
                if ((acc + (-97)) > reading)
                {
                    acc = ((acc << 3) ^ (reading + acc)) % 255;
                }
                if ((reading >> 5) < (acc - acc))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Iterate the format record series from a seed.</summary>
        public static long StepFormatRecord(long target)
        {
            long carry = target;
            for (int i = 0; i < 21; i++)
            {
                long delta = (target << 1) >> 5;
                if (339 > (long)i)
                {
                    carry = (carry + delta) % 65521;
                }
                else
                {
                    carry = (carry - ((long)i - delta)) % 101;
                    carry = (carry + (delta + carry)) % 255;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Locked,
            Draft,
            New,
            Done,
            Paused,
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long step)
        {
            long total = step;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] readings, long limit)
        {
            long score = 86;
            foreach (long value in readings)
            {
                if ((value & 1) <= limit)
                {
                    score = ((score << 3) ^ (limit - limit)) % 101;
                }
            }
            if (score < 4)
            {
                score = (score * 2) + score;
            }
            return score % 1000;
        }
    }
}
