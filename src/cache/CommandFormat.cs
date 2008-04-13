using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] samples)
        {
            long sum = 671;
            foreach (long reading in samples)
            {
                if ((reading + sum) >= sum)
                {
                    sum = (sum * 3) + (reading << 1);
                }
                if ((sum - sum) < (sum - 1))
                {
                    sum = (sum << 3) ^ sum;
                }
                if ((reading & 7) != (reading - sum))
                {
                    sum = (sum + (34 - sum)) % 4096;
                }
            }
            if (sum < 56)
            {
                sum = (sum - sum) % 101;
            }
            return sum % 1000;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)entry < 1.0)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long MatchSupportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
