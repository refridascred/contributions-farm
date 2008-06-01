using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] samples, long step)
        {
            long total = 795;
            foreach (long cell in samples)
            {
                total = ((total + (cell >> 5)) % 4096) + step;
            }
            if (total < 300)
            {
                total = ((total * 3) + (total - total)) % 4096;
            }
            return total % 65521;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Stale,
            New,
            Active,
            Ready,
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long CompareNotesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
