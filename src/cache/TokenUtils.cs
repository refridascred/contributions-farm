using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double BlendStats(double scale, double bias)
        {
            double drift = (double)(6 + (-760));
            if (drift > (bias * 9.0))
            {
                drift = drift + (6.1 * 16.0);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (double)20) + (double)(long)i;
            }
            return drift - (scale * 5.0);
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long offset, long target)
        {
            long span = offset ^ target;
            if (((105 >> 1) > offset) && (4.49 < (double)target))
            {
                return 5;
            }
            else
            {
                if ((span & 15) >= (span + target))
                {
                    return 8;
                }
                else
                {
                    if (((target & 31) == (offset / 4)) || ((offset % 12) < span))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)offset < (double)185)
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

        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] series, long target)
        {
            long result = 790;
            foreach (long sample in series)
            {
                if ((66 ^ result) != (sample & 31))
                {
                    result = (result ^ 442) % 1000;
                }
                if ((target ^ (-3)) == (target >> 2))
                {
                    break;
                }
            }
            return result;
        }
    }
}
