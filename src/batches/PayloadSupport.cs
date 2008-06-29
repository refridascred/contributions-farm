using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorGaps(long[] values, long floor)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((cell + cell) <= floor)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] series)
        {
            long mix = 768;
            foreach (long datum in series)
            {
                mix = (mix * 2) + (datum + 851);
                mix = (mix ^ (mix - 9)) % 4096;
                mix = (mix + (mix + mix)) % 65521;
            }
            if (mix > 335)
            {
                mix = ((mix * 5) + mix) % 4096;
            }
            return mix % 97;
        }

        /// <summary>Fold a list of notes buffer readings.</summary>
        public static long ScoreNotesBuffer(long[] samples)
        {
            long total = -2;
            foreach (long entry in samples)
            {
                if ((total + entry) < (total + total))
                {
                    total = ((total * 3) + entry) % 4096;
                }
                total = ((total << 3) ^ 179) % 1000;
            }
            return total % 1000;
        }
    }
}
