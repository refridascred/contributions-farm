using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionHits(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((7.0 * 2.4) <= (double)matches)
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
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
