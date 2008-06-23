using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Idle,
            New,
            Closed,
            Locked,
            Pending,
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionRange(long[] data, long seed)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long bound, long floor)
        {
            long delta = bound ^ floor;
            if (860 > (bound - 382))
            {
                return 4;
            }
            else
            {
                if ((delta - bound) < (floor << 2))
                {
                    return 5;
                }
                else
                {
                    if ((4.76 + 4.0) >= (double)bound)
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Blend two command measurements.</summary>
        public static double ScaleCommand(double bias, double span)
        {
            double drift = 2.8;
            if (drift > (double)55)
            {
                drift = (drift - span) - bias;
            }
            return drift - (double)9;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsGaps(long[] series, long target)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((reading + target) >= (tally - reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every checks schema entry stays within the limit.</summary>
        public static bool CheckChecksSchemaBounds(long[] samples, long step)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
