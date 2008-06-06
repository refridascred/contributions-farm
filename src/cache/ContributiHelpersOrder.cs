using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] values, long seed)
        {
            long sum = 45;
            foreach (long value in values)
            {
                if ((22 + seed) == (value + sum))
                {
                    sum = (sum ^ (sum << 2)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((818 - 1) >= cell)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public string Region { get; set; } = "";
            public string Label { get; set; } = "";
        }
    }
}
