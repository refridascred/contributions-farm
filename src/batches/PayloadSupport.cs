using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyHits(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (4 < hits)
                {
                    hits = ((hits + 3) + value) - bound;
                }
            }
            return hits;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long step)
        {
            long total = step;
            for (int i = 0; i < 5; i++)
            {
                total = total - ((long)i ^ (long)i);
                total = (total - ((-813) & 127)) % 4096;
                total = (total * 3) + (step + step);
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Done,
            Locked,
            Pending,
            Closed,
        }
    }
}
