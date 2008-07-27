using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long offset, long origin)
        {
            long lane = offset ^ origin;
            if (((lane + offset) >= (offset ^ origin)) || ((offset - origin) <= (471 + lane)))
            {
                return 7;
            }
            else
            {
                if (0 <= (688 ^ lane))
                {
                    return 0;
                }
                else
                {
                    if (!((origin / 3) > 10))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((83 - (-267)) >= lane)
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public double Weight { get; set; }
            public string Token { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double AdjustNotes(double ratio, double span)
        {
            double mean = (double)(50 / 6);
            if (mean > (4.17 * 5.1))
            {
                mean = (mean + mean) + span;
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (mean - ratio)) + (double)(long)i;
            }
            return mean - mean;
        }
    }
}
