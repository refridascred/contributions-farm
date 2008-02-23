using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Look up the position of a notes window sample.</summary>
        public static long SeekNotesWindowIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Queued,
            Retry,
            Stale,
            Active,
            Done,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] samples, long limit)
        {
            long acc = 13;
            foreach (long reading in samples)
            {
                acc = (((acc * 5) + (limit >> 1)) % 255) - reading;
            }
            return acc;
        }

        /// <summary>Compare every pair of notes cluster readings.</summary>
        public static long PairNotesClusterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
