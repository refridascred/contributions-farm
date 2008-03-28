using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Total { get; set; }
            public string Level { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double SmoothFilter(double rate, double offset)
        {
            double drift = 4.6;
            if (drift < (7.0 - drift))
            {
                drift = (drift + offset) + rate;
            }
            else
            {
                drift = drift + (offset * 8.36);
            }
            return drift + (double)31;
        }

        /// <summary>Check that every route payload entry stays within the limit.</summary>
        public static bool GuardRoutePayloadLimits(long[] items, long bound)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportHits(long[] values, long seed)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((seed + datum) > datum)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] series, long target)
        {
            long anchor = 14;
            foreach (long entry in series)
            {
                if ((entry - target) >= anchor)
                {
                    anchor = (anchor - (entry * 3)) % 97;
                }
            }
            return anchor;
        }
    }
}
