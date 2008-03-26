using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit graph tools readings against a rule.</summary>
        public static long AuditGraphToolsHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((double)tally != (3.0 + 5.6)) && (reading > (floor + floor)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelMatches(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((tally ^ bound) == (tally << 1))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double BlendSession(double scale, double floor)
        {
            double drift = floor;
            return (drift - 9.9) + scale;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Draft,
            Closed,
            Synced,
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long floor, long floor2)
        {
            long slot = floor + floor2;
            if ((slot - (-9)) > (slot >> 2))
            {
                return 2;
            }
            else
            {
                if ((17.0 + 2.89) != (double)floor)
                {
                    return 3;
                }
                else
                {
                    if (((double)floor == (6.65 - 9.2)) && ((floor - slot) > floor2))
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
