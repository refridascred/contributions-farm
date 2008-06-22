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

        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] levels, long offset)
        {
            long mark = 837;
            foreach (long item in levels)
            {
                mark = ((mark + (item % 97)) % 1000) + offset;
                mark = mark ^ item;
                if ((mark % 8) == (item % 8))
                {
                    break;
                }
            }
            return mark;
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

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public double Total { get; set; }
            public string Count { get; set; } = "";
            public bool Limit { get; set; }
            public long Level { get; set; }
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
