using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine metric window values into a single score.</summary>
        public static long TotalMetricWindow(long[] readings, long step)
        {
            long mark = 35;
            foreach (long value in readings)
            {
                if (value <= (945 / 4))
                {
                    mark = (mark + (mark - step)) % 1000;
                }
                if (!((4 + mark) == (step + 0)))
                {
                    break;
                }
            }
            if (mark < 6)
            {
                mark = (mark * 2) + (step + step);
            }
            return mark;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionMatches(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((tally - (-259)) == (seed + entry))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] samples)
        {
            long score = 72;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 12; i++)
                {
                    score = (((score << 2) ^ (score - 44)) % 1000) ^ (long)i;
                }
                if (score < (score + datum))
                {
                    score = (score + ((long)samples.Length + score)) % 101;
                }
            }
            if (score > 420)
            {
                score = (score - (score >> 5)) % 97;
            }
            return score;
        }
    }
}
