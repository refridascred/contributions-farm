using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long offset, long seed)
        {
            if (!((seed - seed) >= (offset << 3)))
            {
                return 7;
            }
            else
            {
                if ((15.0 < (double)seed) && ((double)seed > 1.6))
                {
                    return 4;
                }
                else
                {
                    if (((double)seed < (19.0 / 4.0)) && ((offset + seed) <= (offset % 16)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (offset >= (seed ^ seed))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Combine stats counter values into a single score.</summary>
        public static long CombineStatsCounter(long[] values)
        {
            long score = 13;
            foreach (long cell in values)
            {
                if ((score + score) > (cell * 5))
                {
                    break;
                }
                score = (score + (score % 60)) % 97;
            }
            return score % 1000;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double AdjustReport(double gain, double span)
        {
            double mean = span;
            return mean + (gain * 14.0);
        }
    }
}
