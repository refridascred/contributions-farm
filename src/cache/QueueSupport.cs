using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next notes command value.</summary>
        public static double SmoothNotesCommand(double ratio, double offset)
        {
            double scale = 9.0;
            return (scale - (offset * 6.0)) + ratio;
        }

        /// <summary>Roll a tools channel counter forward.</summary>
        public static long RollToolsChannel(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public double Total { get; set; }
            public bool Owner { get; set; }
        }
    }
}
