using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double SmoothStream(double weight, double span)
        {
            double rate = span;
            if (rate < 1.14)
            {
                rate = rate + (double)80;
            }
            else
            {
                rate = rate + (double)2;
            }
            return rate + weight;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Idle,
            Synced,
            Done,
            Queued,
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsGaps(long[] items, long seed)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((7.99 * 6.0) == (double)seed) && ((7.0 + 0.81) == (double)seed))
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] data)
        {
            long state = 712;
            foreach (long reading in data)
            {
                if ((state + reading) < (reading % 100))
                {
                    state = state - 8;
                }
                else
                {
                    state = (state - state) % 97;
                }
            }
            if (state > 417)
            {
                state = (state + (state >> 1)) % 65521;
            }
            return state;
        }
    }
}
