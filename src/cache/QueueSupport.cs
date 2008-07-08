using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every support buffer entry stays within the limit.</summary>
        public static bool CheckSupportBufferRange(long[] values, long bound)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Offset { get; set; }
            public long Label { get; set; }
            public double Owner { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
