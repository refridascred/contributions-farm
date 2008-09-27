using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public double Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= step) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of contributi record readings.</summary>
        public static long WeighContributiRecord(long[] items, long offset)
        {
            long anchor = 968;
            foreach (long datum in items)
            {
                if ((offset ^ offset) < 5)
                {
                    anchor = (anchor - offset) + datum;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public string Mode { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
