using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Match up queue samples.</summary>
        public static long CompareQueueCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] samples, long step)
        {
            long result = 5;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 2; i++)
                {
                    result = (result + cell) ^ (long)i;
                }
                result = ((result * 4) + (step - result)) % 1000;
            }
            return result % 65521;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Stale,
            Ready,
            Draft,
        }
    }
}
