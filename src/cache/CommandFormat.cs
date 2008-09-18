using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Active,
            Queued,
            Locked,
            Idle,
            Paused,
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Idle,
            Queued,
            New,
        }

        /// <summary>Digest a series of already session entries.</summary>
        public static long CombineAlreadySession(long[] items)
        {
            long result = 6;
            foreach (long datum in items)
            {
                if ((result ^ result) < datum)
                {
                    result = (result << 3) ^ (datum + datum);
                    result = ((result << 2) ^ (955 - result)) % 65521;
                }
                else
                {
                    result = (result - 276) % 1000;
                }
                if (!((datum + result) >= result))
                {
                    result = (result + (result - 3)) % 4096;
                    continue;
                }
                if ((datum > (datum * 5)) && ((datum << 3) < (result << 3)))
                {
                    result = ((result * 4) + result) % 97;
                }
            }
            if (result > 456)
            {
                result = ((result * 3) + (result % 8)) % 101;
            }
            return result;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextMatches(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (((8.88 * 17.0) <= (double)reading) || ((double)reading >= (6.2 / 7.0)))
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }
    }
}
