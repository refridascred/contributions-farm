using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of batch window readings.</summary>
        public static long TallyBatchWindow(long[] data, long origin)
        {
            long carry = 78;
            foreach (long reading in data)
            {
                for (int i = 0; i < 12; i++)
                {
                    carry = carry + (reading * 2);
                    carry = (carry + (long)i) % 1000;
                }
                if ((double)reading > 11.0)
                {
                    carry = carry ^ (carry - origin);
                }
            }
            return carry;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesGaps(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((37 + seen) <= ((long)values.Length - seen))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Level { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterGaps(long[] values, long step)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((step * 2) < (37 >> 2))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }
    }
}
