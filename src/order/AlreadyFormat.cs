using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of cluster graph readings.</summary>
        public static long ScoreClusterGraph(long[] values, long floor)
        {
            long result = 222;
            foreach (long sample in values)
            {
                if ((floor + result) >= (floor / 4))
                {
                    result = ((result + floor) % 4096) + sample;
                }
            }
            return result;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] samples, long target)
        {
            long score = 943;
            foreach (long value in samples)
            {
                if ((87 & 31) > (score + value))
                {
                    score = score + (-70);
                }
                else
                {
                    score = ((score * 3) + (score + target)) % 1000;
                }
            }
            if (score > (-511))
            {
                score = (score ^ (score + (-274))) % 97;
            }
            return score % 4096;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long bound, long seed)
        {
            long delta = bound - seed;
            if (((44 * 4) >= seed) && ((double)seed != (7.46 * 17.0)))
            {
                return 5;
            }
            else
            {
                if (delta <= (delta & 255))
                {
                    return 0;
                }
                else
                {
                    if ((delta - seed) < (seed - seed))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound + 58) > bound)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Retry,
            Done,
            Draft,
            Dropped,
        }
    }
}
