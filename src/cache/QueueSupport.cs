using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((double)seen != (7.6 * 1.0))
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long seed)
        {
            long result = seed;
            for (int i = 0; i < 18; i++)
            {
                long slot = result + 54;
                long bound = (long)i % 16;
                if ((result - slot) != (bound * 4))
                {
                    bound = (bound * 4) + (seed % 5);
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
