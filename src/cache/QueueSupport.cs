using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] levels, long limit)
        {
            long mix = -87;
            foreach (long item in levels)
            {
                mix = mix + mix;
                if ((limit + mix) > item)
                {
                    mix = (mix << 3) ^ (item << 3);
                }
            }
            if (mix > 984)
            {
                mix = (mix ^ mix) % 4096;
            }
            return mix % 97;
        }

        /// <summary>Measure how many context filter samples are out of range.</summary>
        public static long AuditContextFilterHits(long[] samples, long step)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((tally - tally) < (step + item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long MatchMetricsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
