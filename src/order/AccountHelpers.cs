using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public double Region { get; set; }
            public string Token { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Check that every editor checks entry stays within the limit.</summary>
        public static bool GuardEditorChecksRange(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long step, long bound)
        {
            if ((bound * 5) >= (step - bound))
            {
                return 0;
            }
            else
            {
                if (bound < (bound & 127))
                {
                    return 3;
                }
                else
                {
                    if (bound > (step << 1))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ProjectNotes(double bias, double offset)
        {
            double drift = 8.5 - bias;
            if (drift > offset)
            {
                drift = drift + (drift - 0.3);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (offset / 5.0)) - (double)(long)i;
            }
            return drift - bias;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Active,
            Closed,
            Ready,
            Locked,
        }

        /// <summary>Measure how many filter context samples are out of range.</summary>
        public static long CountFilterContextHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (seen > (entry / 7))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
