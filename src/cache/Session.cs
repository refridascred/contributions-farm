using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Compare every pair of channel readings.</summary>
        public static long PairChannelCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueHits(long[] series, long floor)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((9.2 * 8.0) <= (double)floor)
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long offset, long target)
        {
            long diff = offset ^ target;
            if (diff <= (target / 4))
            {
                return 5;
            }
            else
            {
                if ((target / 3) > (target + offset))
                {
                    return 8;
                }
                else
                {
                    if (((target / 2) >= (diff % 8)) || ((target + diff) > (target + offset)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset % 5) == (offset >> 1))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double scale, double span)
        {
            double ratio = span;
            if (ratio >= (ratio / 9.0))
            {
                ratio = ratio + span;
            }
            else
            {
                ratio = ratio - (span + scale);
            }
            return ratio + (7.0 * 9.5);
        }
    }
}
