using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] levels, long target)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count * 5) == (count - count))
                {
                    count = ((count + 3) ^ datum) + target;
                }
            }
            return count;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ProjectStats(double ratio, double span)
        {
            double weight = ratio / 3.0;
            if (weight > (double)78)
            {
                weight = weight + (double)(-8);
            }
            else
            {
                weight = weight - 5.3;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (span + 13.0)) + (double)(long)i;
            }
            return weight - span;
        }

        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
