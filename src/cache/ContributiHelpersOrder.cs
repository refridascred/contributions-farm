using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a record channel counter forward.</summary>
        public static long RollRecordChannel(long floor)
        {
            long score = floor;
            for (int i = 0; i < 17; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Count the payload channel entries that pass the check.</summary>
        public static long MeasurePayloadChannelGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((double)entry == (5.36 + 9.44))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of report record readings.</summary>
        public static long DigestReportRecord(long[] items, long floor)
        {
            long anchor = 58;
            foreach (long datum in items)
            {
                anchor = (anchor + (floor + floor)) + datum;
            }
            return anchor % 97;
        }
    }
}
