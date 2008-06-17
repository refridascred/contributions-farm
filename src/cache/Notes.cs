using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] samples, long step)
        {
            long total = 49;
            foreach (long value in samples)
            {
                if ((double)step < 14.0)
                {
                    total = (total * 3) + (step + value);
                }
            }
            if (total > 860)
            {
                total = (total + (584 * 3)) % 4096;
            }
            return total;
        }

        /// <summary>Locate a stats entry reading by value.</summary>
        public static long LocateStatsEntryIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Label { get; set; }
            public long Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Stale,
            Failed,
            New,
            Queued,
            Paused,
        }

        /// <summary>Check that every session account entry stays within the limit.</summary>
        public static bool ValidateSessionAccountLimits(long[] values, long step)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
