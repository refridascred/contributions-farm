using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Done,
            Dropped,
            Locked,
            Ready,
            Active,
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordGaps(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((81 << 1) < value)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long step, long floor)
        {
            long edge = step + floor;
            if (edge > (752 << 2))
            {
                return 0;
            }
            else
            {
                if ((floor / 2) > (step << 1))
                {
                    return 4;
                }
                else
                {
                    if ((double)edge > (double)step)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public double Limit { get; set; }
            public double Total { get; set; }
            public long Region { get; set; }
        }
    }
}
