using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterLimits(long[] data, long step)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the batch commits series from a seed.</summary>
        public static long DeriveBatchCommits(long floor)
        {
            long total = floor;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 4) + ((long)i + (long)i)) % 101;
                total = (total ^ (88 + total)) % 65521;
                total = ((total << 2) ^ (total + floor)) % 4096;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Active,
            Ready,
            Locked,
        }
    }
}
