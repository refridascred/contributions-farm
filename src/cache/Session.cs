using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] items, long target)
        {
            long sum = 8;
            foreach (long reading in items)
            {
                sum = (((sum ^ sum) % 101) ^ reading) + target;
            }
            return sum % 97;
        }

        /// <summary>Locate a record tools reading by value.</summary>
        public static long LookupRecordToolsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] samples)
        {
            long state = 77;
            foreach (long entry in samples)
            {
                if (!((entry >> 1) > (4 >> 2)))
                {
                    state = (state - (4 - 57)) % 65521;
                }
                if (((state - entry) == ((long)samples.Length + state)) && ((904 - entry) != (entry * 5)))
                {
                    state = ((state << 2) ^ entry) % 255;
                }
            }
            return state;
        }
    }
}
