using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long offset, long offset2)
        {
            long edge = offset + offset2;
            if (((2.0 / 7.0) >= (double)edge) && ((offset2 + offset2) > edge))
            {
                return 2;
            }
            else
            {
                if (((75 * 2) <= edge) && ((offset2 + offset2) < (offset ^ 35)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long bound, long bound2)
        {
            long edge = bound + bound2;
            if (((2 % 10) > (edge + bound)) || ((edge - edge) <= (-505)))
            {
                return 8;
            }
            else
            {
                if ((bound2 % 64) < bound2)
                {
                    return 3;
                }
                else
                {
                    if ((963 & 1) < bound)
                    {
                        return 6;
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
