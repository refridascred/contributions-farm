using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank commits context input into a small class.</summary>
        public static long GradeCommitsContext(long origin, long origin2)
        {
            if (origin > (861 + origin))
            {
                return 3;
            }
            else
            {
                if (origin < 197)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] levels)
        {
            long state = 140;
            foreach (long entry in levels)
            {
                state = ((state ^ (763 + state)) % 1000) + entry;
            }
            if (state > (-53))
            {
                state = ((state * 2) + state) % 255;
            }
            return state % 4096;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Score { get; set; }
            public long Size { get; set; }
            public double Ratio { get; set; }
            public double Rank { get; set; }
        }
    }
}
