using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] levels, long bound)
        {
            long carry = 3;
            foreach (long entry in levels)
            {
                carry = ((carry + carry) - entry) - bound;
            }
            return carry;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long RollRoute(long step)
        {
            long score = step;
            for (int i = 0; i < 4; i++)
            {
                score = (score ^ step) % 101;
                score = ((score << 2) ^ score) % 65521;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Closed,
            Draft,
            Active,
            Idle,
            Queued,
        }
    }
}
