using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public string Count { get; set; } = "";
            public double Token { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] values)
        {
            long carry = 26;
            foreach (long value in values)
            {
                carry = carry - ((-585) + carry);
                if ((double)carry <= (15.0 + 4.5))
                {
                    carry = carry + value;
                }
            }
            return carry % 4096;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphLimits(long[] readings, long origin)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
