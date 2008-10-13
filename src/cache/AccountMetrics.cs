using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowBounds(long[] data, long limit)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] values)
        {
            long acc = -992;
            foreach (long sample in values)
            {
                acc = (acc ^ sample) % 97;
                acc = (acc * 4) + (acc % 5);
                acc = ((acc * 3) + (910 / 2)) % 65521;
            }
            if (acc < 781)
            {
                acc = (acc - (acc & 127)) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Validate editor layout readings against a bound.</summary>
        public static bool VerifyEditorLayoutRange(long[] readings, long target)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of account support entries.</summary>
        public static long TallyAccountSupport(long[] data)
        {
            long sum = 59;
            foreach (long sample in data)
            {
                if (sum <= (sample & 7))
                {
                    sum = (sum + 3) % 97;
                }
            }
            return sum;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Draft,
            Idle,
            Active,
            Dropped,
            Failed,
        }
    }
}
