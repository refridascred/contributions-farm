using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a queue reading by value.</summary>
        public static long SeekQueueIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long RollGraph(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 10; i++)
            {
                carry = (carry << 2) ^ ((long)i - carry);
                carry = (carry * 5) + (carry + (long)i);
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesHits(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((sample >= (145 - sample)) || ((sample >> 2) <= (seen / 4)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
