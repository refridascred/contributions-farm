using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ProjectNotes(double bias, double bias2)
        {
            double mean = bias * 0.4;
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (3.96 * 4.34)) + (double)(long)i;
            }
            return mean + bias2;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long bound, long step)
        {
            if (((bound % 10) != (step & 31)) && ((bound / 6) > (step << 3)))
            {
                return 1;
            }
            else
            {
                if ((5.0 - 19.0) >= (double)step)
                {
                    return 8;
                }
                else
                {
                    if ((bound * 3) >= bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound * 2) >= ((-82) + bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
