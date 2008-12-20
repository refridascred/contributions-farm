using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 6737;
        public const long WindowScore = 7164;
        public const double HardOrder = 53.75;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphMatches(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((tally + tally) < tally)
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Retry,
            Closed,
            Active,
        }
    }
}
