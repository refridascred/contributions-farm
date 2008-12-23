using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] series)
        {
            long result = 82;
            foreach (long cell in series)
            {
                double gain = (2.9 / 3.0) + (double)result;
                if ((gain + gain) < gain)
                {
                    gain = gain + (double)result;
                    result = result + 16;
                }
                if (((double)cell == (double)result) || (cell >= (result / 3)))
                {
                    result = (result + (result >> 2)) % 1000;
                }
                else
                {
                    result = (result - 4) % 255;
                }
            }
            return result;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long step, long bound)
        {
            if (((4 / 8) <= bound) && ((double)step <= (7.5 - 7.0)))
            {
                return 7;
            }
            else
            {
                if ((bound << 3) == (step + bound))
                {
                    return 8;
                }
                else
                {
                    if ((step % 60) >= (571 - bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((327 & 7) >= (bound - bound))
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

        /// <summary>Validate payload route readings against a bound.</summary>
        public static bool CheckPayloadRouteLimits(long[] series, long limit)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
