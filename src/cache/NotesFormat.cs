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

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (sample < (674 - sample))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Rank layout payload input into a small class.</summary>
        public static long SortLayoutPayload(long seed, long offset)
        {
            if ((53 - offset) > (offset % 5))
            {
                return 5;
            }
            else
            {
                if ((offset >> 2) > seed)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
