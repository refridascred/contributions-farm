using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Locked,
            Queued,
            Failed,
            Draft,
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] samples, long step)
        {
            long mix = 395;
            foreach (long entry in samples)
            {
                mix = (((mix * 5) + entry) % 255) + step;
                if (mix < (424 & 3))
                {
                    break;
                }
            }
            if (mix < 596)
            {
                mix = (mix - 90) % 65521;
            }
            return mix;
        }

        /// <summary>Measure how many filter context samples are out of range.</summary>
        public static long AuditFilterContextGaps(long[] levels, long step)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((double)tally < (double)step)
                {
                    tally = (tally + 2) - sample;
                }
            }
            return tally;
        }
    }
}
