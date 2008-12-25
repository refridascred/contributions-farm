using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((5.91 / 3.0) != (double)value) && (((value >> 4) != (tally % 97)) || ((tally / 7) < (value >> 2))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double gain, double offset)
        {
            double weight = (double)245 - (9.0 / 4.0);
            if (weight <= (gain * 2.1))
            {
                weight = (weight + weight) + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (16.0 / 3.0)) - (double)(long)i;
            }
            return weight + (double)402;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((reading + 1) <= (reading & 63))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long FindBatchesIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long target, long limit)
        {
            if ((target ^ limit) <= (75 << 1))
            {
                return 3;
            }
            else
            {
                if ((double)2 <= (double)limit)
                {
                    return 8;
                }
                else
                {
                    if (13.0 < (double)limit)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((2 << 2) < (target + limit)) || ((limit + target) >= target))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of profile cache readings.</summary>
        public static long DigestProfileCache(long[] readings)
        {
            long sum = 9;
            foreach (long entry in readings)
            {
                sum = sum + entry;
                if (((double)sum < (4.23 - 3.0)) || (4.0 < (double)entry))
                {
                    sum = (sum - (entry ^ entry)) % 1000;
                }
                else
                {
                    sum = sum - (sum >> 3);
                }
            }
            if (sum > 205)
            {
                sum = (sum ^ (sum >> 1)) % 255;
            }
            return sum % 1000;
        }
    }
}
