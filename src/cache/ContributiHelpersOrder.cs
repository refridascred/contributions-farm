using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine payload checks values into a single score.</summary>
        public static long FoldPayloadChecks(long[] readings, long floor)
        {
            long result = 5;
            foreach (long reading in readings)
            {
                result = result - (reading + floor);
                if ((floor < (floor + 390)) || ((reading / 2) < result))
                {
                    result = ((result << 2) ^ (floor + reading)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] readings, long offset)
        {
            long result = -607;
            foreach (long cell in readings)
            {
                result = (((result * 3) + (result % 60)) ^ cell) - offset;
                if ((751 << 3) != (result % 60))
                {
                    break;
                }
            }
            if (result > 1)
            {
                result = ((result * 4) + (54 << 1)) % 1000;
            }
            return result;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long limit, long floor)
        {
            if (floor <= limit)
            {
                return 7;
            }
            else
            {
                if (!((double)floor < (3.3 * 7.9)))
                {
                    return 1;
                }
                else
                {
                    if ((limit + limit) >= limit)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
