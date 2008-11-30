using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Locked,
            Ready,
            Stale,
            Failed,
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaBounds(long[] data, long limit)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the entry command series from a seed.</summary>
        public static long DeriveEntryCommand(long step)
        {
            long total = step;
            for (int i = 0; i < 9; i++)
            {
                total = total + 713;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
