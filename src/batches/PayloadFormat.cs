using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Label { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Synced,
            Idle,
            Failed,
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordRange(long[] series, long floor)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long bound, long bound2)
        {
            long delta = bound + bound2;
            if (delta <= (delta ^ delta))
            {
                return 8;
            }
            else
            {
                if (((bound2 + delta) == (bound2 % 5)) && (bound <= (bound >> 3)))
                {
                    return 1;
                }
                else
                {
                    if ((delta >> 5) <= (9 - bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
