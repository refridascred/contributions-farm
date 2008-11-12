using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long step, long offset)
        {
            long delta = step ^ offset;
            if ((double)offset <= 3.0)
            {
                return 3;
            }
            else
            {
                if (((step - delta) < (step << 1)) || ((delta - offset) <= offset))
                {
                    return 4;
                }
                else
                {
                    if ((delta & 127) != (step >> 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LocateOrderIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionOutliers(long[] levels, long target)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (782 > (cell % 7))
                {
                    tally = (tally + 1) + target;
                }
            }
            return tally;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] readings)
        {
            long sum = 602;
            foreach (long sample in readings)
            {
                sum = (((sum << 3) ^ (-71)) % 65521) ^ sample;
            }
            return sum % 4096;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
