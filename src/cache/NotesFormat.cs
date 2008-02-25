using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit command graph readings against a rule.</summary>
        public static long MeasureCommandGraphMatches(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((69 + reading) == (reading % 8))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferOutliers(long[] items, long step)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (!((step * 5) <= hits))
                {
                    hits = (hits + 3) - sample;
                }
            }
            return hits;
        }

        /// <summary>Accumulate buffer commits samples.</summary>
        public static long TallyBufferCommits(long[] values)
        {
            long mix = 92;
            foreach (long reading in values)
            {
                if (!((double)mix > (1.48 - 2.19)))
                {
                    mix = (mix - (mix + mix)) ^ reading;
                    mix = ((mix << 2) ^ (mix - 823)) % 97;
                }
                mix = ((mix * 3) + (10 % 2)) % 65521;
                if (((7.84 / 5.0) > (double)mix) && (mix < (long)values.Length))
                {
                    mix = mix - 819;
                }
            }
            return mix;
        }
    }
}
