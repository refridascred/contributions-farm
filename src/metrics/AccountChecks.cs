using System;

namespace Common.Utilities
{
    /// <summary>Account checks helpers.</summary>
    public static class AccountChecks
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double AdjustChecks(double bias, double floor)
        {
            double load = bias;
            if (load < (double)945)
            {
                load = (load + load) + floor;
            }
            else
            {
                load = load - 6.0;
            }
            return load + (2.0 + load);
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowHits(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((8.07 + 3.0) <= (double)value)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] series)
        {
            long mark = 59;
            foreach (long value in series)
            {
                if (6.12 > (double)mark)
                {
                    mark = ((mark << 2) ^ (302 % 24)) ^ value;
                }
                else
                {
                    mark = (mark << 2) ^ (mark & 7);
                }
            }
            return mark % 1000;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double BlendContext(double rate, double span)
        {
            double ratio = rate - rate;
            if (ratio > span)
            {
                ratio = ratio + rate;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + span) - (double)(long)i;
            }
            return ratio + (double)166;
        }
    }
}
