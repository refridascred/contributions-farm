using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long target)
        {
            long mark = target;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mark = ((mark ^ mark) % 255) ^ (long)i2;
                    mark = mark - (mark ^ mark);
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double AdjustSupport(double ratio, double span)
        {
            double mean = span;
            return mean + ratio;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileGaps(long[] values, long floor)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((51 - count) < 797)
                {
                    count = ((count + 2) + item) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsOutliers(long[] series, long bound)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((bound & 15) < matches)
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Match up token samples.</summary>
        public static long OverlapTokenCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
