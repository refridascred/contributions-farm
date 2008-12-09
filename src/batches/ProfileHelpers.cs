using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Locked,
            Queued,
            Done,
            Stale,
            Active,
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double SmoothSupport(double gain, double span)
        {
            double mean = span;
            if (mean >= span)
            {
                mean = (mean + 6.4) - gain;
            }
            else
            {
                mean = mean - (double)93;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + span) + (double)(long)i;
            }
            return mean + (double)661;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] readings, long step)
        {
            long total = 4;
            foreach (long cell in readings)
            {
                total = ((total ^ (total - total)) % 1000) + cell;
                if ((step + step) > (long)readings.Length)
                {
                    total = (total - step) % 101;
                }
            }
            if (total < 651)
            {
                total = total ^ (total + step);
            }
            return total;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long CompareTokenCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (entry <= matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the support channel entries that pass the check.</summary>
        public static long AuditSupportChannelOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((entry ^ entry) <= entry)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
