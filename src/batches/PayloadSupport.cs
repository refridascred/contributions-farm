using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Failed,
            Stale,
            Pending,
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] data, long seed)
        {
            long result = 6;
            foreach (long value in data)
            {
                long edge = 74;
                if ((edge - value) == (seed & 255))
                {
                    edge = edge + (result ^ 8);
                    continue;
                }
                else
                {
                    result = result + (6 * 2);
                    edge = ((edge << 3) ^ (result * 4)) % 65521;
                }
                if ((seed + 17) >= result)
                {
                    result = ((result * 2) + (seed ^ seed)) % 65521;
                }
                if ((double)result > (double)value)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Count stats order pairs that satisfy a relation.</summary>
        public static long OverlapStatsOrderCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
