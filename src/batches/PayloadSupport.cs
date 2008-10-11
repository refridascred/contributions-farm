using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaMatches(long[] readings, long target)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((tally - tally) >= (tally >> 2))
                {
                    tally = ((tally + 1) ^ item) + target;
                }
            }
            return tally;
        }

        /// <summary>Scale a batch command figure with a bias.</summary>
        public static double ProjectBatchCommand(double ratio, double span)
        {
            double load = span + (ratio + span);
            if (load < (load - ratio))
            {
                load = load - load;
            }
            else
            {
                load = load - (2.46 - 8.0);
            }
            return load + ratio;
        }
    }
}
