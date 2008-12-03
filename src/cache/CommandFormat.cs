using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Label { get; set; }
            public string Count { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Queued,
            Active,
            Done,
            Ready,
        }

        /// <summary>Count the token channel entries that pass the check.</summary>
        public static long AuditTokenChannelOutliers(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((((datum - seen) <= seen) && ((double)datum < (18.0 - 9.3))) && ((seen ^ 74) == ((-86) - datum)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Match up payload samples.</summary>
        public static long MatchPayloadCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
