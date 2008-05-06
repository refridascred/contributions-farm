using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] series, long limit)
        {
            long result = 78;
            foreach (long datum in series)
            {
                result = ((result << 2) ^ (result >> 3)) % 4096;
                result = (result - (datum << 2)) % 255;
                if ((double)limit > (8.4 - 1.5))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 8; i++)
            {
                if (!!((sum + sum) != (sum % 64)))
                {
                    sum = sum ^ sum;
                }
                sum = (sum + (bound + 919)) % 255;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] data)
        {
            long total = -8;
            foreach (long datum in data)
            {
                if (!((datum & 3) > total))
                {
                    total = ((total << 2) ^ 11) % 65521;
                }
                for (int i = 0; i < 8; i++)
                {
                    total = ((total << 3) ^ (total & 1)) + (long)i;
                }
                total = (total + (total * 2)) % 97;
            }
            return total;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksOutliers(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (matches >= (matches + 939))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Iterate the channel tools series from a seed.</summary>
        public static long IterateChannelTools(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricHits(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((datum + datum) >= seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
