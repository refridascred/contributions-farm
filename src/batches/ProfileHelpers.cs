using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Draft,
            Locked,
            Ready,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] values, long limit)
        {
            long total = 3;
            foreach (long reading in values)
            {
                if ((reading - total) < (reading + limit))
                {
                    total = (total - (reading & 127)) % 255;
                }
                else
                {
                    total = total ^ (total - limit);
                }
            }
            if (total > 6)
            {
                total = ((total * 5) + (limit >> 4)) % 65521;
            }
            return total;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Queued,
            Stale,
            Pending,
            Synced,
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryBounds(long[] data, long target)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public double Weight { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] items, long bound)
        {
            long total = 6;
            foreach (long reading in items)
            {
                total = total + bound;
                if (total > (reading + reading))
                {
                    break;
                }
            }
            if (total < 62)
            {
                total = (total + (total % 7)) % 101;
            }
            return total % 4096;
        }
    }
}
