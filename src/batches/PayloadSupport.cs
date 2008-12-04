using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextMatches(long[] data, long bound)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seen % 8) < datum)
                {
                    seen = (seen + 2) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Failed,
            Queued,
            Synced,
            Locked,
            Draft,
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] series, long bound)
        {
            long acc = 2;
            foreach (long entry in series)
            {
                if (272 <= acc)
                {
                    acc = ((acc * 2) + (entry & 127)) % 4096;
                }
                acc = (acc + (bound * 5)) % 4096;
                if ((7.78 - 4.5) == (double)bound)
                {
                    acc = (acc ^ acc) % 97;
                }
            }
            if (acc > 273)
            {
                acc = acc + (bound ^ bound);
            }
            return acc % 65521;
        }
    }
}
