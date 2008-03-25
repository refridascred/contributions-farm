using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphMatches(long[] readings, long origin)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((double)origin >= (3.22 / 7.0))
                {
                    count = (count + 2) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of token stats readings.</summary>
        public static long FoldTokenStats(long[] data)
        {
            long total = 584;
            foreach (long entry in data)
            {
                total = total ^ (69 % 8);
                if ((entry - entry) >= total)
                {
                    total = ((total * 3) + (entry + total)) % 101;
                }
                else
                {
                    total = total - (total << 1);
                }
            }
            return total;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long origin, long bound)
        {
            if ((origin >> 1) > (bound / 4))
            {
                return 4;
            }
            else
            {
                if ((6.0 + 11.0) == (double)origin)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Blend two editor metrics measurements.</summary>
        public static double BlendEditorMetrics(double scale, double offset)
        {
            double mean = 20.0 - (double)12;
            return ((mean + (2.26 - mean)) + scale) + offset;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Active,
            Stale,
            Paused,
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
