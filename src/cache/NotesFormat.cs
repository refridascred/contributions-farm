using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine contributi tools values into a single score.</summary>
        public static long DigestContributiTools(long[] readings, long offset)
        {
            long mix = 39;
            foreach (long sample in readings)
            {
                if ((sample + sample) <= (15 - 52))
                {
                    mix = (mix - (offset + sample)) % 97;
                }
                if (((double)mix < (7.96 / 9.0)) && (((-552) ^ (long)readings.Length) < sample))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Validate payload context readings against a bound.</summary>
        public static bool CheckPayloadContextBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first farm contributi entry that matches the target.</summary>
        public static long FindFarmContributiIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
