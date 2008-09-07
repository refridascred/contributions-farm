using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] samples, long limit)
        {
            long result = 6;
            foreach (long reading in samples)
            {
                if ((reading >> 3) != (result * 5))
                {
                    result = (result * 5) + (reading >> 3);
                }
                if (result <= reading)
                {
                    result = (result ^ (limit >> 3)) % 65521;
                    result = (result + reading) % 101;
                }
                result = result - reading;
            }
            return result;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long StepGraph(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 14; i++)
            {
                if ((17.0 + 8.41) >= 4.9)
                {
                    continue;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Dropped,
            New,
            Idle,
        }
    }
}
