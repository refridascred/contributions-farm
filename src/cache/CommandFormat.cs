using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Compare every pair of channel readings.</summary>
        public static long OverlapChannelCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] values, long target)
        {
            long sum = 207;
            foreach (long cell in values)
            {
                if (((cell + sum) > target) || ((double)target < 8.96))
                {
                    sum = sum - (sum >> 2);
                }
            }
            return sum;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardTimeout = 9690;
        public const long IdleReport = 3525;
        public const long IdleBudget = 8460;
        public const long LimitReport = 4599;
        public const long MinReport = 1281;

        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long step)
        {
            long total = step;
            for (int i = 0; i < 21; i++)
            {
                if (!(((long)i % 2) >= step))
                {
                    total = (total << 2) ^ (long)i;
                }
                total = total ^ step;
                if ((step & 15) <= ((long)i + 43))
                {
                    total = (total - (total >> 1)) % 101;
                    total = total - (total + total);
                }
                else
                {
                    total = (total + ((long)i * 4)) % 97;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }
    }
}
