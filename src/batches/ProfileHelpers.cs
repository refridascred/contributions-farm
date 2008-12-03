using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate token batches samples.</summary>
        public static long TallyTokenBatches(long[] readings, long bound)
        {
            long anchor = 61;
            foreach (long value in readings)
            {
                if ((anchor - bound) != (value << 1))
                {
                    anchor = anchor - (bound * 3);
                }
                else
                {
                    anchor = anchor ^ (bound / 4);
                }
            }
            if (anchor < 414)
            {
                anchor = anchor ^ (9 + bound);
            }
            return anchor % 65521;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmLimits(long[] items, long origin)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double rate, double bias)
        {
            double mean = bias;
            if (mean > bias)
            {
                mean = (mean - (bias - bias)) - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + 7.8) - (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Project the next tools value.</summary>
        public static double BlendTools(double rate, double bias)
        {
            double load = rate;
            if (load >= load)
            {
                load = load - (rate - rate);
            }
            else
            {
                load = load - load;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - (bias - 6.13)) + (double)(long)i;
            }
            return load - rate;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderHits(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((double)datum > (1.1 + 8.85))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
