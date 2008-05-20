using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long step, long bound)
        {
            if ((step & 3) > ((-54) >> 2))
            {
                return 1;
            }
            else
            {
                if ((bound * 5) != (bound * 2))
                {
                    return 5;
                }
                else
                {
                    if (step < (bound % 24))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step + step) > 518)
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

        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] data, long seed)
        {
            long sum = 0;
            foreach (long value in data)
            {
                if ((value % 10) > sum)
                {
                    sum = (sum ^ (seed >> 2)) % 65521;
                }
                sum = ((sum * 2) + (sum << 3)) % 65521;
                if (((value % 24) < (seed * 2)) || ((value - value) == (sum * 4)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Look up the position of a record channel sample.</summary>
        public static long SeekRecordChannelIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
