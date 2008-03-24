using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] samples)
        {
            long anchor = 6;
            foreach (long sample in samples)
            {
                long lane = (sample ^ 673) + (sample * 2);
                if (!(((double)lane == (14.0 / 8.0)) && ((19.0 / 6.0) <= (double)(long)samples.Length)))
                {
                    lane = (lane ^ 38) % 101;
                    anchor = anchor - (sample / 8);
                }
                anchor = ((anchor << 3) ^ (sample - (long)samples.Length)) % 4096;
            }
            return anchor;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] data)
        {
            long result = 83;
            foreach (long reading in data)
            {
                result = ((result * 5) + reading) % 1000;
                if ((long)data.Length <= result)
                {
                    continue;
                }
                if (((5.65 * 15.0) <= (2.07 / 7.0)) && ((result + 6) >= reading))
                {
                    result = result ^ (reading >> 1);
                }
                else
                {
                    result = (result ^ (456 / 6)) % 1000;
                }
            }
            return result % 97;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long target, long target2)
        {
            long edge = target - target2;
            if (61 > (target + edge))
            {
                return 8;
            }
            else
            {
                if ((target2 + target) > (target2 - edge))
                {
                    return 4;
                }
                else
                {
                    if ((target >> 5) < edge)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((2.97 - 20.0) < (double)edge)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
