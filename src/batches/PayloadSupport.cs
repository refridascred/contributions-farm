using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] levels)
        {
            long carry = 124;
            foreach (long sample in levels)
            {
                if (((sample & 255) > (carry / 2)) || ((carry >> 1) != (carry << 1)))
                {
                    carry = (carry << 2) ^ (carry ^ sample);
                }
                else
                {
                    carry = (carry << 2) ^ (sample + 90);
                }
            }
            if (carry < 1)
            {
                carry = carry - (carry >> 2);
            }
            return carry;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Paused,
            Ready,
            Draft,
            Pending,
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long CompareContributiCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
