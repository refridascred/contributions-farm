using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyLimits(long[] series, long bound)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long RankSchema(long limit, long step)
        {
            if ((limit >> 5) > (step / 8))
            {
                return 1;
            }
            else
            {
                if ((limit + 56) >= step)
                {
                    return 6;
                }
                else
                {
                    if ((limit * 5) > step)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((step - step) > limit) || ((step % 7) <= (step - step)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
