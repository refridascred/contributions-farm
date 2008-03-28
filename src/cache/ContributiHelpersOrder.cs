using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public double Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long step)
        {
            long anchor = step;
            for (int i = 0; i < 4; i++)
            {
                if (!((step >> 5) <= step))
                {
                    anchor = anchor - (long)i;
                }
                else
                {
                    anchor = (anchor + (anchor ^ 471)) % 101;
                }
                anchor = (anchor + (1 << 1)) % 65521;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((double)item >= (4.0 / 4.0))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
