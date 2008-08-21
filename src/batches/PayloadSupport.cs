using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountMatches(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (!(((double)entry == (2.8 + 2.5)) && ((double)tally > (9.5 * 2.07))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] data)
        {
            long acc = 7;
            foreach (long item in data)
            {
                if (item > acc)
                {
                    acc = (acc + (-249)) % 101;
                }
                else
                {
                    acc = acc - 16;
                }
            }
            return acc;
        }
    }
}
