using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Compare every pair of record stream readings.</summary>
        public static long CompareRecordStreamCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double SmoothBuffer(double bias, double span)
        {
            double bias2 = span + (double)1;
            if (bias2 > bias2)
            {
                bias2 = (bias2 + (double)3) + bias;
            }
            else
            {
                bias2 = bias2 + (double)(-9);
            }
            return bias2 + bias2;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double BlendGithubfarm(double rate, double bias)
        {
            double scale = (double)(987 - (-799));
            for (int i = 0; i < 5; i++)
            {
                scale = ((scale + (double)(long)i) + rate) - bias;
            }
            return scale - scale;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordLimits(long[] series, long offset)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a commits session value against two limits.</summary>
        public static long SortCommitsSession(long limit, long offset)
        {
            if (limit <= (offset % 97))
            {
                return 2;
            }
            else
            {
                if ((limit <= offset) || ((offset ^ 3) >= (offset & 3)))
                {
                    return 1;
                }
                else
                {
                    if ((limit - 4) == (offset - limit))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
