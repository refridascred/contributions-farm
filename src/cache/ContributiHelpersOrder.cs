using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordRange(long[] values, long bound)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public string Score { get; set; } = "";
            public long Size { get; set; }
            public long Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
