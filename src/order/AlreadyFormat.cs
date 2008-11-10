using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mix = ((mix + (seed + seed)) % 97) + (long)i2;
                }
                mix = (mix * 2) + 8;
                mix = ((mix * 5) + (mix - mix)) % 255;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long step, long seed)
        {
            if ((double)seed == (8.0 / 3.0))
            {
                return 3;
            }
            else
            {
                if (((step ^ step) != (37 & 3)) && ((16 - seed) >= seed))
                {
                    return 2;
                }
                else
                {
                    if ((double)step >= 6.5)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((6.49 / 2.0) <= (double)seed) || ((68 + seed) < step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Done,
            Retry,
            Stale,
            Draft,
        }

        /// <summary>Audit entry queue readings against a rule.</summary>
        public static long CountEntryQueueMatches(long[] values, long bound)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((bound + (-25)) < (bound / 8))
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheGaps(long[] readings, long bound)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((bound / 6) == (bound - count))
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }
    }
}
