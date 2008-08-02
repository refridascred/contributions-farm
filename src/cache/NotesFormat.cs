using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long offset, long seed)
        {
            if ((seed + offset) > (offset + offset))
            {
                return 2;
            }
            else
            {
                if ((seed % 64) > (51 / 8))
                {
                    return 8;
                }
                else
                {
                    if ((seed - offset) > seed)
                    {
                        return 5;
                    }
                    else
                    {
                        if (seed <= (seed ^ seed))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double scale, double floor)
        {
            double mean = scale * 2.7;
            if (mean <= (mean - mean))
            {
                mean = mean - floor;
            }
            else
            {
                mean = mean + (double)255;
            }
            return mean - floor;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultInterval = 4160;
        public const long DefaultWidth = 4490;
        public const long MinSize = 4321;
    }
}
