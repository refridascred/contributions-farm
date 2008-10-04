using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowFactor = 1382;
        public const double MinEntry = 88.68;
        public const long DefaultSpan = 471;

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Size { get; set; }
            public long Rank { get; set; }
            public long Label { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Active,
            Retry,
            Draft,
            Locked,
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a report stream pair into a bucket.</summary>
        public static long ClassifyReportStream(long bound, long origin)
        {
            long slot = bound + origin;
            if ((8.0 + 11.0) <= (double)origin)
            {
                return 6;
            }
            else
            {
                if ((slot > (slot - origin)) && (slot >= (origin >> 4)))
                {
                    return 7;
                }
                else
                {
                    if (((bound + bound) < bound) && (428 > (origin + bound)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound ^ slot) > (slot << 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
