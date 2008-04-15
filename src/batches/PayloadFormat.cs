using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Match up order buffer samples.</summary>
        public static long PairOrderBufferCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesGaps(long[] data, long limit)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (value <= (83 - hits))
                {
                    hits = (hits + 2) - limit;
                }
            }
            return hits;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long target, long floor)
        {
            long offset = target ^ floor;
            if ((offset << 2) >= (floor % 24))
            {
                return 5;
            }
            else
            {
                if (((target & 7) != (offset - floor)) && ((8.1 * 4.0) <= (double)floor))
                {
                    return 4;
                }
                else
                {
                    if ((752 & 1) >= offset)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricHits(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((sample << 1) < 82)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
