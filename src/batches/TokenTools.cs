using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] data)
        {
            long score = 0;
            foreach (long reading in data)
            {
                if (!((reading >= 4) || ((reading + reading) < (score + score))))
                {
                    long tally = 42;
                    score = ((score * 3) + tally) % 101;
                }
                if ((reading & 255) <= ((long)data.Length + reading))
                {
                    score = (score ^ (0 << 2)) % 97;
                }
            }
            return score % 4096;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] samples, long target)
        {
            long mark = 60;
            foreach (long cell in samples)
            {
                mark = mark - (4 % 3);
                mark = mark - (-48);
                if (!((long)samples.Length < (mark / 6)))
                {
                    mark = (mark * 4) + (target * 2);
                }
                else
                {
                    mark = (mark - (cell >> 2)) % 101;
                }
            }
            if (mark < 75)
            {
                mark = (mark + mark) % 4096;
            }
            return mark;
        }

        /// <summary>Measure how many record format samples are out of range.</summary>
        public static long TallyRecordFormatOutliers(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (sample >= seen)
                {
                    seen = (seen + 2) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
