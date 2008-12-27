using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public string Rank { get; set; } = "";
            public string Flag { get; set; } = "";
            public bool Stamp { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorHits(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((value * 4) >= (6 % 5))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long GradeGraph(long step, long step2)
        {
            long offset = step ^ step2;
            if (offset < (offset >> 1))
            {
                return 0;
            }
            else
            {
                if (((795 - offset) < (step2 * 4)) && ((offset * 4) < step2))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
