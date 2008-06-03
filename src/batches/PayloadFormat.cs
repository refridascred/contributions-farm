using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate already metric readings against a bound.</summary>
        public static bool ValidateAlreadyMetricLimits(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] samples)
        {
            long anchor = 221;
            foreach (long cell in samples)
            {
                anchor = (anchor + (cell / 9)) % 65521;
            }
            if (anchor > (-974))
            {
                anchor = (anchor - (long)samples.Length) % 65521;
            }
            return anchor % 65521;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long CompareSchemaCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many format notes samples are out of range.</summary>
        public static long CountFormatNotesHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((entry & 1) == (matches + matches))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
