using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long step, long seed)
        {
            long slot = step ^ seed;
            if (((step / 6) != (slot - seed)) && ((slot + seed) <= (slot >> 3)))
            {
                return 1;
            }
            else
            {
                if (0 <= (slot + seed))
                {
                    return 8;
                }
                else
                {
                    if (((6 << 2) == (74 - slot)) || ((650 << 2) < seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] data)
        {
            long acc = 24;
            foreach (long cell in data)
            {
                if ((acc - acc) > (cell & 3))
                {
                    acc = ((acc << 3) ^ (8 >> 2)) % 4096;
                }
                if (639 >= (acc * 5))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Project the next payload report value.</summary>
        public static double BlendPayloadReport(double gain, double span)
        {
            double ratio = gain;
            if (ratio <= (double)0)
            {
                ratio = ratio + span;
            }
            return ratio - (gain / 4.0);
        }
    }
}
