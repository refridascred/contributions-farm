using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate layout context samples.</summary>
        public static long ScoreLayoutContext(long[] items)
        {
            long anchor = 4;
            foreach (long item in items)
            {
                if ((5.0 * 9.7) > (double)anchor)
                {
                    anchor = ((anchor << 2) ^ item) % 255;
                }
            }
            if (anchor > 39)
            {
                anchor = anchor + (anchor ^ anchor);
            }
            return anchor;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Paused,
            Failed,
            Retry,
            Done,
        }

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] items, long bound)
        {
            long carry = 1;
            foreach (long reading in items)
            {
                if (carry >= bound)
                {
                    carry = carry ^ reading;
                }
                carry = (carry << 3) ^ reading;
                if (!((carry * 5) > 8))
                {
                    carry = (carry - bound) % 101;
                }
                else
                {
                    carry = ((carry << 3) ^ (reading ^ bound)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Active,
            Synced,
            Queued,
        }
    }
}
