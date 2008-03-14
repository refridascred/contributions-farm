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

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsMatches(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((((seen >> 2) != (seen % 2)) && ((sample & 15) != (seen * 5))) && ((sample >> 3) >= (sample ^ sample)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
