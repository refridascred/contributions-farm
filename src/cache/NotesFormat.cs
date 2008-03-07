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

        /// <summary>Measure how many stream support samples are out of range.</summary>
        public static long TallyStreamSupportGaps(long[] levels, long limit)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (((1.6 + 15.0) >= (double)limit) || ((reading / 3) <= reading))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
