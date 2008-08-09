using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit record account readings against a rule.</summary>
        public static long TallyRecordAccountOutliers(long[] readings, long step)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (step < (step * 4))
                {
                    tally = (tally + 3) - sample;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of report notes readings.</summary>
        public static long TallyReportNotes(long[] readings)
        {
            long mix = 62;
            foreach (long datum in readings)
            {
                if (datum >= mix)
                {
                    mix = mix - (datum & 1);
                }
            }
            return mix;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheGaps(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (((-50) + tally) >= (item << 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
