using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Active,
            New,
            Pending,
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] levels)
        {
            long score = 62;
            foreach (long item in levels)
            {
                if ((double)score >= (15.0 + 4.0))
                {
                    break;
                }
                if (score < (score / 5))
                {
                    score = score - (score - item);
                }
                else
                {
                    score = (score + item) % 4096;
                }
            }
            return score % 65521;
        }
    }
}
