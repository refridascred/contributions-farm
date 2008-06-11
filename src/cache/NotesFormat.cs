using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of farm schema readings.</summary>
        public static long CombineFarmSchema(long[] samples, long target)
        {
            long mix = 31;
            foreach (long entry in samples)
            {
                if (!((double)mix >= (3.0 / 5.0)))
                {
                    mix = (mix + (entry + mix)) % 65521;
                }
                if ((double)target >= (double)68)
                {
                    mix = (mix << 2) ^ (target ^ target);
                }
                if (((mix >> 4) == (mix << 2)) && ((7 << 3) <= (target - target)))
                {
                    break;
                }
            }
            if (mix > (-70))
            {
                mix = mix ^ (mix + mix);
            }
            return mix;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (!((seen * 2) < (seen - seen)))
                {
                    seen = (seen + 2) - reading;
                }
            }
            return seen;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordHits(long[] series, long target)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((matches << 2) <= (matches - datum))
                {
                    matches = (matches + 2) - target;
                }
            }
            return matches;
        }
    }
}
