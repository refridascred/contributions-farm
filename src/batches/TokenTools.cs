using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadGaps(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (((sample * 4) >= (sample << 2)) || ((double)641 != (double)sample))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Closed,
            Draft,
            Retry,
            Locked,
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Draft,
            Ready,
            Closed,
        }
    }
}
