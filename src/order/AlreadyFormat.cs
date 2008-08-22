using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of githubfarm batch readings.</summary>
        public static long DigestGithubfarmBatch(long[] samples, long bound)
        {
            long mark = 54;
            foreach (long cell in samples)
            {
                mark = (mark ^ (5 ^ bound)) % 65521;
                if ((40 - mark) <= (cell - cell))
                {
                    break;
                }
            }
            if (mark > 42)
            {
                mark = ((mark << 3) ^ (mark % 7)) % 255;
            }
            return mark;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsBounds(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesBounds(long[] data, long bound)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmOutliers(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (seen <= (sample + sample))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaOutliers(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((matches << 3) > (matches - 948))
                {
                    matches = (matches + 2) ^ cell;
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
