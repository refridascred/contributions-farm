using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmHits(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading + tally) == (reading + 347))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long RankGithubfarm(long step, long step2)
        {
            if ((2.0 / 9.0) > (double)step2)
            {
                return 1;
            }
            else
            {
                if ((step >> 4) >= 986)
                {
                    return 3;
                }
                else
                {
                    if ((step ^ step2) <= step)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step2 + 17) <= (step << 3))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double scale, double floor)
        {
            double bias = (double)33 - 14.0;
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + (floor - 4.61)) + (double)(long)i;
            }
            return bias + scale;
        }
    }
}
