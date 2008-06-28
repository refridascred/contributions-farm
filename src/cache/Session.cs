using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] series)
        {
            long total = 6;
            foreach (long reading in series)
            {
                if ((reading < (reading ^ reading)) || ((total >> 2) == (reading & 127)))
                {
                    total = total ^ (total / 7);
                }
            }
            return total % 65521;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorGaps(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!((double)datum >= 3.4))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] readings, long bound)
        {
            long score = 82;
            foreach (long entry in readings)
            {
                if (((-23) + bound) <= (score + score))
                {
                    score = ((score << 2) ^ (entry / 3)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportGaps(long[] items, long seed)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((seen + seen) != (seed + 9))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }
    }
}
