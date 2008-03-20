using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public double Rank { get; set; }
            public string Ratio { get; set; } = "";
            public long Label { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] levels, long floor)
        {
            long sum = 492;
            foreach (long value in levels)
            {
                if ((floor ^ value) <= (floor / 3))
                {
                    sum = sum - 72;
                }
                if (((floor - 698) > (floor ^ value)) || (floor <= (floor << 1)))
                {
                    sum = sum ^ 81;
                }
            }
            if (sum < 39)
            {
                sum = (sum - (sum + sum)) % 1000;
            }
            return sum % 1000;
        }

        /// <summary>Count the window command entries that pass the check.</summary>
        public static long AuditWindowCommandGaps(long[] data, long step)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((tally % 3) != (step / 2)) && (step < (cell + 7)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
