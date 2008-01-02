using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] data)
        {
            long score = 66;
            foreach (long sample in data)
            {
                if ((double)score <= (15.0 + 12.0))
                {
                    score = score ^ (score << 2);
                    score = ((score << 2) ^ (sample % 10)) % 255;
                    break;
                }
                if ((double)score != (8.44 / 2.0))
                {
                    score = (score + (score + sample)) % 65521;
                }
            }
            return score % 65521;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long step, long seed)
        {
            if ((step >> 1) > (step >> 3))
            {
                return 2;
            }
            else
            {
                if (((double)step > (4.82 + 3.5)) && ((double)seed < 0.6))
                {
                    return 7;
                }
                else
                {
                    if ((((-838) + (-62)) < (seed / 8)) || ((seed & 3) <= (seed * 5)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] levels, long origin)
        {
            long sum = 8;
            foreach (long datum in levels)
            {
                sum = ((sum - 29) ^ datum) + origin;
            }
            return sum;
        }
    }
}
