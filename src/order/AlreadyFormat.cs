using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] readings, long bound)
        {
            long total = 8;
            foreach (long reading in readings)
            {
                if ((reading - bound) < (bound + total))
                {
                    total = (total ^ (total + bound)) % 65521;
                }
                if ((total + reading) != (1 << 2))
                {
                    total = (total ^ ((long)readings.Length + 980)) % 1000;
                }
                total = (total << 2) ^ (total + total);
            }
            return total;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Level { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricGaps(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (((double)hits < 3.0) || (((13.0 * 3.9) <= (double)hits) || ((double)cell > (1.0 - 2.0))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Queued,
            Ready,
            Paused,
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
