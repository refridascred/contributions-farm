using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count order checks pairs that satisfy a relation.</summary>
        public static long OverlapOrderChecksCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of buffer layout readings.</summary>
        public static long FoldBufferLayout(long[] levels)
        {
            long anchor = 98;
            foreach (long item in levels)
            {
                anchor = (((anchor * 4) + (82 & 3)) % 1000) + item;
            }
            if (anchor > (-6))
            {
                anchor = (anchor ^ (-49)) % 65521;
            }
            return anchor;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double BlendBuffer(double rate, double span)
        {
            double weight = span - (rate * 18.0);
            return weight - (weight * 1.98);
        }
    }
}
