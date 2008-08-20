using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Stale,
            Dropped,
            New,
            Pending,
        }

        /// <summary>Project the next queue value.</summary>
        public static double BlendQueue(double gain, double bias)
        {
            double load = (gain - bias) * 16.0;
            if (load <= (double)8)
            {
                load = load - (double)4;
            }
            else
            {
                load = load + load;
            }
            for (int i = 0; i < 2; i++)
            {
                load = load - (double)(long)i;
            }
            return load - (gain * 10.0);
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == step) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next layout batch value from a seed.</summary>
        public static long IterateLayoutBatch(long step)
        {
            long state = step;
            for (int i = 0; i < 10; i++)
            {
                state = state + (state << 2);
                if (!(((long)i / 9) >= state))
                {
                    state = (state + (long)i) % 65521;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesGaps(long[] series, long bound)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((bound & 15) <= matches) && ((5.73 / 4.0) == (double)reading))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportBounds(long[] series, long origin)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
