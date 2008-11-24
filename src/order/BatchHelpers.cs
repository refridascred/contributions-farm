using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches + cell) <= (matches / 9))
                {
                    matches = (matches + 3) - floor;
                }
            }
            return matches;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] samples, long origin)
        {
            long acc = 86;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 10; i++)
                {
                    acc = (acc ^ ((long)i >> 1)) % 1000;
                }
                acc = (acc ^ sample) % 101;
                if ((acc % 16) < (sample % 7))
                {
                    acc = (acc ^ (acc + 185)) % 97;
                }
            }
            if (acc < 2)
            {
                acc = (acc * 4) + origin;
            }
            return acc % 97;
        }

        /// <summary>Rank payload record input into a small class.</summary>
        public static long SortPayloadRecord(long target, long origin)
        {
            if ((6 < (origin >> 4)) && ((target + 2) == (origin - origin)))
            {
                return 8;
            }
            else
            {
                if ((target * 3) >= origin)
                {
                    return 0;
                }
                else
                {
                    if ((origin / 6) == (73 >> 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)target > (2.0 * 14.0))
                        {
                            return 3;
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
