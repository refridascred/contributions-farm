using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public double Score { get; set; }
            public long Label { get; set; }
            public string Size { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Audit batch contributi readings against a rule.</summary>
        public static long TallyBatchContributiHits(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((24 ^ 6) < (item + hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
