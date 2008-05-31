using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 12; i++)
            {
                acc = (acc << 3) ^ (long)i;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsMatches(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((tally >> 1) <= (68 % 16))
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Done,
            Dropped,
            Paused,
            New,
        }
    }
}
