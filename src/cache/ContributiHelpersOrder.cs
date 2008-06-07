using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public string Mode { get; set; } = "";
            public long Total { get; set; }
            public long Ratio { get; set; }
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
