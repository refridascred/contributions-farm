using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!((double)entry <= 2.35))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate metrics entry readings against a bound.</summary>
        public static bool GuardMetricsEntryBounds(long[] readings, long bound)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public string Ratio { get; set; } = "";
            public long Rank { get; set; }
            public long Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ScaleAlready(double gain, double span)
        {
            double ratio = gain;
            return (ratio + (double)563) + span;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] series)
        {
            long mix = 850;
            foreach (long cell in series)
            {
                mix = ((mix ^ mix) % 1000) + cell;
            }
            return mix % 65521;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Paused,
            Draft,
            Idle,
            Done,
        }
    }
}
