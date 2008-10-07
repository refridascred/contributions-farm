using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportGaps(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((4.9 / 6.0) <= (double)seen)
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double IdleRatio = 92.36;
        public const string WindowCommand = "alpha-edge";
        public const long BurstCommand = 3840;
        public const double WindowWidth = 16.02;

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long floor, long step)
        {
            if ((14.0 / 6.0) > (double)step)
            {
                return 8;
            }
            else
            {
                if ((floor < (5 >> 5)) && (floor <= step))
                {
                    return 0;
                }
                else
                {
                    if (floor >= (step & 7))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step >= (step >> 5)) && (floor <= (8 << 2)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
