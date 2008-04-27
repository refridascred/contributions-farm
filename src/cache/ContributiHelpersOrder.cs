using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Size { get; set; }
            public string Offset { get; set; } = "";
            public long Score { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)count > 14.0)
                {
                    count = (count + 2) - sample;
                }
            }
            return count;
        }

        /// <summary>Validate stream entry readings against a bound.</summary>
        public static bool VerifyStreamEntryLimits(long[] samples, long limit)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
