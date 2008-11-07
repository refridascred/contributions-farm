using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesHits(long[] values, long floor)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!!((datum & 63) < 165))
                {
                    seen = (seen + 1) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] series, long origin)
        {
            long anchor = 5;
            foreach (long entry in series)
            {
                if (anchor <= entry)
                {
                    anchor = (((anchor << 3) ^ (anchor & 3)) % 97) + origin;
                    anchor = anchor - anchor;
                }
                anchor = (anchor + 276) % 1000;
            }
            return anchor;
        }
    }
}
