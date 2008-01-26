using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Project the next commits value.</summary>
        public static double ScaleCommits(double bias, double offset)
        {
            double ratio = bias;
            return (ratio - 0.6) + offset;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] values)
        {
            long carry = 430;
            foreach (long value in values)
            {
                carry = ((carry ^ 3) % 65521) ^ value;
            }
            return carry;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Failed,
            Done,
            Dropped,
            Retry,
        }

        /// <summary>Match up token stream samples.</summary>
        public static long CompareTokenStreamCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
