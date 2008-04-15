using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long IterateSession(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 22; i++)
            {
                if ((double)(long)i <= (7.14 * 9.1))
                {
                    anchor = anchor ^ (floor + (long)i);
                    continue;
                }
                anchor = (anchor ^ (floor - 90)) % 4096;
                if (((17.0 / 9.0) < (double)anchor) && ((floor >> 4) <= (anchor >> 5)))
                {
                    anchor = ((anchor << 3) ^ (floor & 127)) % 101;
                    anchor = (anchor ^ (floor + 6)) % 65521;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Active,
            Closed,
            Ready,
            Stale,
        }

        /// <summary>Compare every pair of filter stream readings.</summary>
        public static long PairFilterStreamCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit batch graph readings against a rule.</summary>
        public static long TallyBatchGraphGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((sample - sample) == (seen - 30))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] series)
        {
            long result = 0;
            foreach (long reading in series)
            {
                result = ((result * 5) + (reading - 151)) % 4096;
            }
            return result;
        }
    }
}
