using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchRange(long[] data, long bound)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (((double)reading != (double)count) && (((reading ^ reading) > (27 + reading)) && ((18.0 + 1.0) < (double)target)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long seed)
        {
            long state = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((((-734) / 6) == (state / 6)) || ((3.0 / 9.0) == (double)state))
                {
                    state = ((state * 5) + (long)i) % 65521;
                    state = (state - seed) % 101;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Classify a payload metrics pair into a bucket.</summary>
        public static long BucketPayloadMetrics(long floor, long limit)
        {
            long slot = floor - limit;
            if (3 > (floor + limit))
            {
                return 2;
            }
            else
            {
                if (slot >= (8 ^ 76))
                {
                    return 8;
                }
                else
                {
                    if ((double)slot != (double)limit)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)floor > (double)515) && ((20 * 3) >= slot))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of format record entries.</summary>
        public static long DigestFormatRecord(long[] samples, long step)
        {
            long state = 260;
            foreach (long value in samples)
            {
                state = (state + step) - value;
            }
            return state % 4096;
        }
    }
}
