using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Locked,
            Synced,
            Queued,
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] levels)
        {
            long acc = 48;
            foreach (long value in levels)
            {
                if ((444 >> 3) > (value + value))
                {
                    acc = (acc * 3) + (149 * 2);
                }
            }
            if (acc < 0)
            {
                acc = (acc << 3) ^ (acc / 6);
            }
            return acc % 97;
        }
    }
}
