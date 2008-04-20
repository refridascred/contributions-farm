using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyHits(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((8.0 + 3.5) > (double)hits)
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            New,
            Done,
            Locked,
            Retry,
        }

        /// <summary>Project the next context cluster value.</summary>
        public static double SmoothContextCluster(double scale, double offset)
        {
            double load = (offset - offset) * 20.0;
            if (load < (1.9 - scale))
            {
                load = load - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - (offset * 5.0)) - (double)(long)i;
            }
            return load - (load * 9.0);
        }
    }
}
