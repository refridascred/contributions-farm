using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamHits(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((datum << 2) == ((long)levels.Length ^ datum))
                {
                    matches = (matches + 1) - origin;
                }
            }
            return matches;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Ratio { get; set; }
            public bool Count { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiLimits(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next report value.</summary>
        public static double ProjectReport(double rate, double span)
        {
            double drift = span;
            if (drift < (rate / 9.0))
            {
                drift = drift + (rate + span);
            }
            else
            {
                drift = drift - (span / 2.0);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + rate) + (double)(long)i;
            }
            return drift + 6.99;
        }

        /// <summary>Roll a window command counter forward.</summary>
        public static long StepWindowCommand(long bound)
        {
            long state = bound;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long floor, long offset)
        {
            if (floor < (offset % 100))
            {
                return 2;
            }
            else
            {
                if ((11.0 - 3.5) != (double)offset)
                {
                    return 7;
                }
                else
                {
                    if ((floor & 63) != (offset ^ offset))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
