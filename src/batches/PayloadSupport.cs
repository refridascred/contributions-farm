using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsOutliers(long[] data, long floor)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)(-518) >= (double)entry)
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long target, long step)
        {
            long cur = target ^ step;
            if ((9.8 * 1.01) >= (double)cur)
            {
                return 6;
            }
            else
            {
                if (((6.5 - 16.0) <= (double)step) || ((step << 1) <= (549 ^ target)))
                {
                    return 3;
                }
                else
                {
                    if (((target - cur) <= (step & 255)) || (step >= (step << 3)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (cur >= (27 >> 3))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
