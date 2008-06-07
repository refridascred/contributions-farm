using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long IterateRecord(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 9; i++)
            {
                if ((seed / 4) < (long)i)
                {
                    sum = (sum * 2) + seed;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public bool Owner { get; set; }
            public bool Label { get; set; }
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
