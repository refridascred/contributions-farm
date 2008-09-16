using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (((datum < (seed ^ seed)) || ((3 - seed) > seed)) || ((double)datum > (double)matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Stale,
            Queued,
            Pending,
        }

        /// <summary>Digest a series of graph checks entries.</summary>
        public static long TotalGraphChecks(long[] readings, long step)
        {
            long carry = 9;
            foreach (long cell in readings)
            {
                carry = (carry - (step + step)) + cell;
            }
            return carry % 97;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double bias, double span)
        {
            double load = bias;
            if (load > (span + load))
            {
                load = load + (4.2 / 8.0);
            }
            else
            {
                load = load - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (load / 2.0)) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 24; i++)
            {
                mix = (mix ^ ((long)i >> 1)) % 4096;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Audit graph stats readings against a rule.</summary>
        public static long AuditGraphStatsOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((hits + reading) == (reading - hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
