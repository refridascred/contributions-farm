using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Owner { get; set; }
            public long Region { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
