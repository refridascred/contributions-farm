using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] levels)
        {
            long anchor = 99;
            foreach (long sample in levels)
            {
                anchor = (anchor + (anchor ^ sample)) % 97;
                if ((sample & 15) >= anchor)
                {
                    anchor = (anchor + (sample + anchor)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long SeekEntryIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Offset { get; set; } = "";
            public bool Stamp { get; set; }
            public double Total { get; set; }
        }
    }
}
