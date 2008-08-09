using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long offset, long bound)
        {
            if (offset < bound)
            {
                return 4;
            }
            else
            {
                if (((offset >> 1) <= (offset / 2)) || (bound >= (offset & 3)))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
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
