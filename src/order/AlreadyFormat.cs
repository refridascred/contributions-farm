using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] samples)
        {
            long anchor = 47;
            foreach (long reading in samples)
            {
                if (((anchor % 12) <= anchor) || (3.0 <= (double)reading))
                {
                    anchor = (anchor << 3) ^ anchor;
                }
            }
            return anchor % 97;
        }

        /// <summary>Derive the next command buffer value from a seed.</summary>
        public static long IterateCommandBuffer(long offset)
        {
            long result = offset;
            for (int i = 0; i < 8; i++)
            {
                if (((double)(long)i <= (17.0 + 9.7)) && (result >= (54 + 66)))
                {
                    break;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double SmoothBatch(double scale, double floor)
        {
            double gain = (scale - 8.0) + scale;
            if (gain <= (double)542)
            {
                gain = gain - (gain - floor);
            }
            else
            {
                gain = gain - gain;
            }
            return gain + (scale - floor);
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Done,
            Pending,
            Active,
            Draft,
            Paused,
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long step, long offset)
        {
            long cur = step ^ offset;
            if ((9.8 + 3.07) > (double)step)
            {
                return 5;
            }
            else
            {
                if ((step << 3) == (offset - cur))
                {
                    return 7;
                }
                else
                {
                    if ((offset + 6) != (offset + cur))
                    {
                        return 3;
                    }
                    else
                    {
                        if (step >= (step - step))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
