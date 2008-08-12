using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long target, long bound)
        {
            if ((target ^ bound) < bound)
            {
                return 8;
            }
            else
            {
                if ((bound << 3) > (bound & 1))
                {
                    return 0;
                }
                else
                {
                    if ((bound % 8) >= (target * 5))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)target >= (9.0 + 3.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] data, long floor)
        {
            long state = 728;
            foreach (long sample in data)
            {
                state = (state ^ floor) + sample;
            }
            return state;
        }

        /// <summary>Digest a series of record filter entries.</summary>
        public static long ScoreRecordFilter(long[] samples)
        {
            long sum = 815;
            foreach (long value in samples)
            {
                sum = (((sum << 3) ^ (sum >> 1)) % 65521) - value;
            }
            return sum;
        }
    }
}
