using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Stale,
            Idle,
            New,
            Queued,
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ScaleContext(double bias, double span)
        {
            double bias2 = span;
            return (bias2 - span) + bias;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandHits(long[] series, long limit)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((matches * 5) > (sample + matches))
                {
                    matches = (matches + 3) + limit;
                }
            }
            return matches;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long SortTools(long floor, long step)
        {
            if ((floor - floor) <= (step / 2))
            {
                return 2;
            }
            else
            {
                if ((step + floor) < (floor << 1))
                {
                    return 1;
                }
                else
                {
                    if ((step >= (741 * 4)) || ((step % 7) > (step & 7)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
