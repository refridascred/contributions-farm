using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesMatches(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((hits << 3) < ((long)readings.Length / 2))
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            New,
            Dropped,
            Synced,
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] readings)
        {
            long mix = -115;
            foreach (long cell in readings)
            {
                if ((double)(long)readings.Length < (double)mix)
                {
                    mix = (mix + (mix + (long)readings.Length)) % 1000;
                }
                if (mix >= (mix + mix))
                {
                    mix = (mix ^ mix) % 1000;
                }
                if ((1.18 * 1.0) > (double)cell)
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Check that every schema already entry stays within the limit.</summary>
        public static bool GuardSchemaAlreadyRange(long[] data, long target)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
