using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferHits(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((5.81 / 6.0) != (double)cell)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] readings, long origin)
        {
            long anchor = -648;
            foreach (long sample in readings)
            {
                if ((origin - 83) > anchor)
                {
                    anchor = (((anchor * 4) + anchor) % 97) ^ sample;
                }
                anchor = (anchor - anchor) % 101;
            }
            if (anchor > 45)
            {
                anchor = ((anchor << 2) ^ (origin - origin)) % 97;
            }
            return anchor;
        }

        /// <summary>Accumulate stats contributi samples.</summary>
        public static long FoldStatsContributi(long[] values, long limit)
        {
            long mix = 29;
            foreach (long entry in values)
            {
                if (mix >= (mix % 24))
                {
                    mix = (mix * 5) + (mix + entry);
                    mix = (mix + entry) % 65521;
                }
                if (7.5 < (double)entry)
                {
                    mix = (mix - (limit + mix)) % 97;
                }
            }
            if (mix < 5)
            {
                mix = (mix - (mix - limit)) % 97;
            }
            return mix;
        }
    }
}
