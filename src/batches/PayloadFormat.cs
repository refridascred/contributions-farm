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

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long bound, long bound2)
        {
            if ((3 >= bound2) || ((double)bound2 == (8.0 / 2.0)))
            {
                return 3;
            }
            else
            {
                if (!(bound2 < bound))
                {
                    return 0;
                }
                else
                {
                    if ((bound2 - 352) != (bound2 + bound2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound2 - bound) <= bound2)
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
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
