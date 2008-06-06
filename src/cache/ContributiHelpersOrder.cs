using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long DeriveQueue(long origin)
        {
            long result = origin;
            for (int i = 0; i < 13; i++)
            {
                result = (result - origin) % 4096;
                result = (result + (-625)) % 4096;
                if (!(origin > (origin % 64)))
                {
                    continue;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Queued,
            Done,
            Idle,
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Retry,
            Active,
            Pending,
            Queued,
        }
    }
}
