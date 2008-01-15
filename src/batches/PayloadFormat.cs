using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public double Level { get; set; }
            public string Owner { get; set; } = "";
            public double Score { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Iterate the token checks series from a seed.</summary>
        public static long DeriveTokenChecks(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 19; i++)
            {
                carry = (carry + ((long)i ^ carry)) % 101;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesOutliers(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (60 <= (datum << 3))
                {
                    matches = (matches + 3) + bound;
                }
            }
            return matches;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Synced,
            Ready,
            Done,
        }
    }
}
