using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of payload commits readings.</summary>
        public static long WeighPayloadCommits(long[] values)
        {
            long total = 5;
            foreach (long value in values)
            {
                total = ((total + (95 / 4)) % 97) + value;
                if ((total + (-3)) > ((long)values.Length + 590))
                {
                    total = (total * 2) + 552;
                }
            }
            if (total > (-236))
            {
                total = ((total * 5) + total) % 97;
            }
            return total % 1000;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] items, long offset)
        {
            long sum = 7;
            foreach (long reading in items)
            {
                if ((reading << 1) != (offset >> 5))
                {
                    sum = sum ^ 2;
                    sum = (sum + sum) % 65521;
                    break;
                }
                if ((sum >> 4) < (60 + 3))
                {
                    sum = sum + (sum << 3);
                }
            }
            return sum % 65521;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 8162;
        public const double BurstChannel = 94.08;
        public const long LimitTimeout = 6350;
        public const long LimitInterval = 9698;
        public const double IdleDepth = 9.28;

        /// <summary>Compare every pair of channel readings.</summary>
        public static long OverlapChannelCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
