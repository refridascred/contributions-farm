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

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] data)
        {
            long sum = 9;
            foreach (long datum in data)
            {
                sum = ((sum * 5) + datum) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Owner { get; set; }
            public double Total { get; set; }
        }
    }
}
