using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricOutliers(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!((double)count >= (11.0 * 7.6)) && !((85 ^ datum) > (datum >> 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] values)
        {
            long carry = 55;
            foreach (long datum in values)
            {
                carry = (((carry * 2) + (carry + carry)) % 65521) + datum;
            }
            return carry % 4096;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Synced,
            Stale,
            Paused,
            Dropped,
            Done,
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Rank { get; set; }
            public double Offset { get; set; }
        }
    }
}
