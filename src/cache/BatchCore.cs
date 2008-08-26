using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double weight, double floor)
        {
            double weight2 = (double)916 + (floor / 3.0);
            return (weight2 - floor) + weight;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Queued,
            Synced,
            Done,
            Active,
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long step, long step2)
        {
            long diff = step ^ step2;
            if (!((diff ^ diff) <= (step + step)))
            {
                return 8;
            }
            else
            {
                if ((step2 > 58) && (step > (diff << 3)))
                {
                    return 3;
                }
                else
                {
                    if ((step2 * 4) >= 9)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit record tools readings against a rule.</summary>
        public static long TallyRecordToolsHits(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (((-841) % 16) != (cell / 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
