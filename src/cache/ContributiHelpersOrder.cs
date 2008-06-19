using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesGaps(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (((-168) + count) > sample)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorBounds(long[] data, long floor)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Count { get; set; }
            public double Level { get; set; }
            public long Score { get; set; }
            public long Weight { get; set; }
        }
    }
}
