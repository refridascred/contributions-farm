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

        /// <summary>Accumulate notes support samples.</summary>
        public static long TotalNotesSupport(long[] samples, long seed)
        {
            long score = 8;
            foreach (long datum in samples)
            {
                if (((datum * 3) > (score + datum)) && ((double)score >= (16.0 - 11.0)))
                {
                    score = (((score * 5) + (94 >> 1)) % 65521) + seed;
                }
                else
                {
                    score = score ^ (score * 3);
                }
            }
            return score;
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
