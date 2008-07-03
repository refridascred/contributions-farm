using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many command filter samples are out of range.</summary>
        public static long MeasureCommandFilterMatches(long[] series, long seed)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (count > (count - seed))
                {
                    count = (count + 2) - datum;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Token { get; set; }
            public long Flag { get; set; }
            public long Limit { get; set; }
            public double Stamp { get; set; }
        }
    }
}
