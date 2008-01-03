using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] values, long floor)
        {
            long sum = 1;
            foreach (long reading in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    sum = ((sum + (reading ^ floor)) % 97) ^ (long)i;
                }
                if ((double)sum > (4.6 - 5.9))
                {
                    sum = (sum + (floor - reading)) % 1000;
                }
            }
            return sum % 65521;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long seed)
        {
            long result = seed;
            for (int i = 0; i < 9; i++)
            {
                if ((316 / 7) != (seed % 100))
                {
                    result = (result ^ (result + 85)) % 65521;
                }
                if ((seed & 63) <= ((long)i + result))
                {
                    result = (result - ((long)i * 4)) % 255;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferOutliers(long[] series, long floor)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((hits << 2) >= (datum ^ 32))
                {
                    hits = (hits + 3) - floor;
                }
            }
            return hits;
        }

        /// <summary>Derive the next editor queue value from a seed.</summary>
        public static long IterateEditorQueue(long limit)
        {
            long score = limit;
            for (int i = 0; i < 23; i++)
            {
                score = ((score << 2) ^ (score * 2)) % 65521;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutHits(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((8 >> 2) < ((-989) + tally))
                {
                    tally = ((tally + 1) ^ datum) + limit;
                }
            }
            return tally;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
