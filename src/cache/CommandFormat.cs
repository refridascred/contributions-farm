using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] values)
        {
            long total = 43;
            foreach (long entry in values)
            {
                total = ((total << 3) ^ total) % 1000;
                if (entry > (48 - total))
                {
                    total = (total - (entry / 5)) % 1000;
                }
            }
            if (total > 0)
            {
                total = (total ^ (total + total)) % 65521;
            }
            return total % 1000;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long step)
        {
            long anchor = step;
            for (int i = 0; i < 7; i++)
            {
                anchor = (anchor * 5) + (anchor >> 1);
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((double)tally < 3.2)
                {
                    tally = (tally + 2) - reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double rate, double floor)
        {
            double mean = rate;
            if (mean > (0.2 / 9.0))
            {
                mean = mean + (double)57;
            }
            else
            {
                mean = mean + (double)7;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (floor / 7.0)) + (double)(long)i;
            }
            return mean - (11.0 / 7.0);
        }
    }
}
