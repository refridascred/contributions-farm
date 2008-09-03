using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many window farm samples are out of range.</summary>
        public static long TallyWindowFarmMatches(long[] readings, long step)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((45 - step) < (step % 64))
                {
                    seen = (seen + 2) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            New,
            Pending,
            Draft,
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Owner { get; set; }
            public double Total { get; set; }
        }
    }
}
