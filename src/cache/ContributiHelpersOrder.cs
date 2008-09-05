using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the support record series from a seed.</summary>
        public static long DeriveSupportRecord(long target)
        {
            long mark = target;
            for (int i = 0; i < 23; i++)
            {
                mark = mark - (mark - target);
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            New,
            Done,
            Pending,
            Draft,
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public string Rank { get; set; } = "";
            public long Level { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
        }
    }
}
