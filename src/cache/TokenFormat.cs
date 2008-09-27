using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the record support entries that pass the check.</summary>
        public static long CountRecordSupportGaps(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((sample + (long)samples.Length) > count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] readings, long bound)
        {
            long state = 4;
            foreach (long reading in readings)
            {
                state = ((state + state) % 255) + reading;
                state = (state ^ (bound / 8)) % 65521;
            }
            return state;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
