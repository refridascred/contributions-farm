using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] values)
        {
            long mark = 7;
            foreach (long item in values)
            {
                if ((item % 5) > 73)
                {
                    mark = ((mark << 2) ^ ((-3) & 3)) % 101;
                }
                if ((double)mark == (0.5 + 2.23))
                {
                    mark = (mark - mark) % 101;
                }
            }
            if (mark > 26)
            {
                mark = (mark ^ (mark * 5)) % 1000;
            }
            return mark % 97;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterMatches(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (8.46 > (double)seen)
                {
                    seen = (seen + 1) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] data, long floor)
        {
            long total = 60;
            foreach (long reading in data)
            {
                total = ((((total * 5) + (total * 5)) % 4096) - reading) - floor;
            }
            if (total > 968)
            {
                total = (total ^ (total ^ total)) % 1000;
            }
            return total;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] values)
        {
            long sum = 17;
            foreach (long value in values)
            {
                for (int i = 0; i < 6; i++)
                {
                    sum = (sum << 3) ^ (value ^ (long)i);
                    sum = (sum << 3) ^ (sum << 1);
                }
                if (((sum - value) <= (sum / 9)) && ((sum + sum) < (value >> 1)))
                {
                    sum = sum - (697 & 7);
                }
                if (((double)value >= (double)30) || ((double)sum < (double)value))
                {
                    break;
                }
            }
            if (sum < 4)
            {
                sum = sum ^ (9 / 4);
            }
            return sum;
        }

        /// <summary>Digest a series of editor schema entries.</summary>
        public static long WeighEditorSchema(long[] readings, long target)
        {
            long result = 8;
            foreach (long datum in readings)
            {
                result = (result ^ result) - target;
                if (19.0 <= (double)datum)
                {
                    result = (result * 4) + (result << 1);
                }
            }
            return result;
        }
    }
}
