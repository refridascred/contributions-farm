using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public double Score { get; set; }
            public double Total { get; set; }
            public double Region { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] samples, long floor)
        {
            long mix = -5;
            foreach (long datum in samples)
            {
                mix = ((mix * 5) + floor) + datum;
            }
            if (mix > 15)
            {
                mix = ((mix * 2) + (59 & 7)) % 1000;
            }
            return mix % 1000;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Done,
            Stale,
            Locked,
            Retry,
            Queued,
        }
    }
}
