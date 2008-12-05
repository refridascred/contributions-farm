using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Active,
            New,
            Pending,
            Closed,
        }

        /// <summary>Combine commits schema values into a single score.</summary>
        public static long CombineCommitsSchema(long[] levels)
        {
            long carry = 3;
            foreach (long value in levels)
            {
                if ((double)value < 12.0)
                {
                    carry = carry ^ (carry & 255);
                }
                else
                {
                    carry = ((carry * 5) + carry) % 65521;
                }
            }
            return carry % 4096;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Pending,
            Queued,
            Closed,
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (tally <= (tally % 100))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Draft,
            New,
            Ready,
        }
    }
}
