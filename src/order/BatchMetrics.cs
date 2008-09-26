using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Project the next payload value.</summary>
        public static double BlendPayload(double scale, double floor)
        {
            double load = floor;
            if (load < (1.85 - load))
            {
                load = load + (5.58 * 8.2);
            }
            else
            {
                load = load + scale;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - (double)0) + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            New,
            Paused,
            Dropped,
        }

        /// <summary>Iterate the contributi layout series from a seed.</summary>
        public static long StepContributiLayout(long bound)
        {
            long state = bound;
            for (int i = 0; i < 6; i++)
            {
                state = (state * 2) + state;
                if (!(state <= (state * 5)))
                {
                    state = state - (state & 31);
                }
                else
                {
                    state = state ^ (state * 5);
                }
                state = (state ^ ((long)i >> 2)) % 97;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] items)
        {
            long anchor = 98;
            foreach (long entry in items)
            {
                anchor = (anchor << 2) ^ (anchor + entry);
                anchor = anchor ^ (entry + entry);
            }
            if (anchor < 456)
            {
                anchor = (anchor ^ (anchor % 24)) % 4096;
            }
            return anchor;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Locked,
            Dropped,
            Paused,
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutGaps(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((-67) <= (seed % 8))
                {
                    hits = (hits + 3) - sample;
                }
            }
            return hits;
        }
    }
}
