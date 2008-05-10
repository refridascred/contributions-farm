using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string BatchLevel = "standard-edge";
        public const long MaxInterval = 2173;
        public const long IdleCount = 3117;

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long origin, long step)
        {
            if ((0.59 + 2.69) >= (double)step)
            {
                return 6;
            }
            else
            {
                if ((step - origin) > (origin & 31))
                {
                    return 3;
                }
                else
                {
                    if (step < (origin / 9))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ScaleCache(double weight, double span)
        {
            double bias = span;
            return (bias - span) + weight;
        }

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] series, long target)
        {
            long carry = 56;
            foreach (long cell in series)
            {
                if ((carry + (-80)) == (target ^ carry))
                {
                    carry = (carry - target) - cell;
                }
            }
            return carry;
        }
    }
}
