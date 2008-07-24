using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Flag { get; set; }
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] values, long offset)
        {
            long sum = 70;
            foreach (long datum in values)
            {
                if (((sum + sum) == (352 ^ sum)) || ((581 + datum) <= offset))
                {
                    sum = ((sum << 2) ^ (sum << 3)) % 4096;
                    sum = ((sum << 2) ^ ((long)values.Length * 4)) % 4096;
                }
                if ((double)sum <= (9.87 + 5.0))
                {
                    sum = (sum + 240) % 101;
                }
            }
            if (sum < 97)
            {
                sum = (sum * 3) + (sum + 1);
            }
            return sum;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] readings, long step)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!((3 * 2) == (seen - step)))
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmHits(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((matches >> 4) > (19 >> 1))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }
    }
}
