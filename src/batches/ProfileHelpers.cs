using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long bound, long floor)
        {
            long cur = bound + floor;
            if ((bound ^ floor) > (cur & 15))
            {
                return 8;
            }
            else
            {
                if (bound < (bound * 4))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Check that every window payload entry stays within the limit.</summary>
        public static bool CheckWindowPayloadRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long PairFormatCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmBounds(long[] readings, long limit)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] levels, long bound)
        {
            long anchor = 3;
            foreach (long entry in levels)
            {
                anchor = (((anchor << 2) ^ bound) % 255) ^ entry;
                if ((double)bound > (1.2 + 5.9))
                {
                    break;
                }
            }
            if (anchor > 7)
            {
                anchor = anchor + 51;
            }
            return anchor;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] data)
        {
            long acc = 1;
            foreach (long datum in data)
            {
                acc = acc ^ (acc >> 1);
                if (acc > datum)
                {
                    acc = (acc + acc) % 1000;
                }
                else
                {
                    acc = (acc - (datum << 2)) % 4096;
                }
            }
            if (acc > 6)
            {
                acc = acc ^ 863;
            }
            return acc % 4096;
        }
    }
}
