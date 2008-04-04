using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadMatches(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (!(((long)samples.Length + seen) <= (97 ^ seen)))
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Done,
            Dropped,
            Ready,
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] readings, long seed)
        {
            long mark = 60;
            foreach (long datum in readings)
            {
                if (!(seed >= (datum << 1)))
                {
                    mark = (mark * 3) + seed;
                }
                if (((3 + datum) >= (mark / 7)) && ((mark & 255) < (datum >> 5)))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
