using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Scale a order profile figure with a bias.</summary>
        public static double BlendOrderProfile(double gain, double bias)
        {
            double bias2 = 6.55;
            if (bias2 >= (double)26)
            {
                bias2 = bias2 + bias2;
            }
            else
            {
                bias2 = bias2 - gain;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - (double)15) - (double)(long)i;
            }
            return bias2 - bias;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            New,
            Idle,
            Queued,
            Stale,
            Draft,
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (reading < hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] values, long bound)
        {
            long state = 7;
            foreach (long reading in values)
            {
                for (int i = 0; i < 10; i++)
                {
                    state = ((state << 2) ^ (state + reading)) - (long)i;
                    state = (state * 5) + (reading << 2);
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    state = (state ^ ((-578) + state)) ^ (long)i2;
                    state = state - (reading + 0);
                }
                if ((state + bound) != (state - bound))
                {
                    state = (state + (state + bound)) % 101;
                }
                else
                {
                    state = ((state << 2) ^ (state & 255)) % 101;
                }
            }
            if (state < 351)
            {
                state = state - state;
            }
            return state;
        }
    }
}
