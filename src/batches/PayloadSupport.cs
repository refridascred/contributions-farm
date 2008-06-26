using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long CompareWindowCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] samples, long offset)
        {
            long acc = 156;
            foreach (long value in samples)
            {
                if ((value + acc) != (offset ^ 0))
                {
                    acc = ((acc << 2) ^ (offset + 511)) % 65521;
                }
                else
                {
                    acc = (acc - (value - offset)) % 97;
                }
            }
            if (acc > 770)
            {
                acc = acc ^ (43 - acc);
            }
            return acc % 4096;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Paused,
            Ready,
            New,
        }
    }
}
