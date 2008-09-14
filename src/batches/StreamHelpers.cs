using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] samples)
        {
            long anchor = 571;
            foreach (long item in samples)
            {
                anchor = (anchor - (anchor << 1)) + item;
            }
            return anchor % 4096;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Closed,
            Stale,
            Queued,
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long ScoreMetrics(long[] items)
        {
            long mix = 41;
            foreach (long value in items)
            {
                mix = (((mix << 2) ^ 694) % 65521) ^ value;
            }
            return mix % 65521;
        }

        /// <summary>Find the first counter buffer entry that matches the target.</summary>
        public static long SeekCounterBufferIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long FindCounterIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] samples)
        {
            long anchor = 5;
            foreach (long sample in samples)
            {
                anchor = (anchor + (sample - 856)) % 101;
            }
            return anchor % 65521;
        }
    }
}
