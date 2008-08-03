using System;

namespace Common.Utilities
{
    /// <summary>Record checks helpers.</summary>
    public static class RecordChecks
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Size { get; set; }
            public bool Mode { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferMatches(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((sample * 5) < (count + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long step)
        {
            long score = step;
            for (int i = 0; i < 20; i++)
            {
                score = score - ((-87) - step);
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
