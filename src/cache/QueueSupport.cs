using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string RetrySchema = "local-1";
        public const long MaxSize = 8158;
        public const string IdleSchema = "staging-v2";
        public const long LimitSchema = 4744;
        public const long WindowSchema = 4956;

        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] values, long origin)
        {
            long mix = 791;
            foreach (long datum in values)
            {
                mix = mix + mix;
                if ((mix + mix) != (origin + origin))
                {
                    mix = ((mix * 5) + (origin << 1)) % 255;
                }
                else
                {
                    mix = (mix + (origin * 5)) % 65521;
                }
                if (((datum + origin) >= (mix % 12)) || ((4 - origin) == (mix + origin)))
                {
                    mix = (mix * 2) + (datum - origin);
                }
            }
            if (mix < 2)
            {
                mix = mix + (992 >> 3);
            }
            return mix % 4096;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (origin > (745 * 3))
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }
    }
}
