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

        /// <summary>Compare every pair of token counter readings.</summary>
        public static long CompareTokenCounterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
