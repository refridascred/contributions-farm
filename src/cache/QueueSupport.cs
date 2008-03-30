using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Score { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] samples)
        {
            long carry = 0;
            foreach (long entry in samples)
            {
                carry = (carry << 2) ^ entry;
                if ((entry % 8) <= (entry * 2))
                {
                    break;
                }
            }
            if (carry < (-8))
            {
                carry = ((carry * 4) + (carry ^ carry)) % 4096;
            }
            return carry % 97;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteMatches(long[] items, long limit)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((6.33 * 7.8) != (double)matches)
                {
                    matches = ((matches + 1) + entry) - limit;
                }
            }
            return matches;
        }
    }
}
