using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] items, long seed)
        {
            long total = -69;
            foreach (long cell in items)
            {
                if ((cell + total) != (seed / 8))
                {
                    total = ((total * 2) + 77) % 97;
                }
                else
                {
                    total = (total - cell) % 97;
                }
            }
            return total % 1000;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Synced,
            Pending,
            Done,
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public bool Owner { get; set; }
            public double Rank { get; set; }
            public long Token { get; set; }
            public double Mode { get; set; }
        }
    }
}
