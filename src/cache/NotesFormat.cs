using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] data, long floor)
        {
            long total = 5;
            foreach (long reading in data)
            {
                total = (total + (floor - reading)) % 101;
            }
            return total % 65521;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesHits(long[] levels, long bound)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)count != (15.0 + 5.2))
                {
                    count = ((count + 2) + item) - bound;
                }
            }
            return count;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long limit, long bound)
        {
            long diff = limit + bound;
            if (((limit + 66) > (bound / 2)) && ((limit - 195) <= (bound * 2)))
            {
                return 1;
            }
            else
            {
                if (((double)bound < (13.0 * 7.92)) && (bound >= diff))
                {
                    return 6;
                }
                else
                {
                    if ((1 - bound) < (limit << 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((4.0 / 9.0) != (double)diff)
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
