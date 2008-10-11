using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] readings)
        {
            long acc = 76;
            foreach (long reading in readings)
            {
                acc = ((acc * 4) + (reading / 8)) % 4096;
            }
            return acc % 97;
        }

        /// <summary>Digest a series of metric entry entries.</summary>
        public static long DigestMetricEntry(long[] data, long floor)
        {
            long state = 0;
            foreach (long entry in data)
            {
                for (int i = 0; i < 3; i++)
                {
                    state = (((state << 2) ^ state) % 65521) + (long)i;
                    state = ((state << 2) ^ floor) % 1000;
                }
                if ((state + state) < (state / 8))
                {
                    state = (state ^ ((-53) ^ floor)) % 97;
                    continue;
                }
                if ((floor / 8) > (state ^ entry))
                {
                    state = state ^ (7 * 5);
                }
                else
                {
                    state = (state - (floor + floor)) % 255;
                }
            }
            return state % 1000;
        }
    }
}
