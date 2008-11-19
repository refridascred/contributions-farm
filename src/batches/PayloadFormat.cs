using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] items)
        {
            long score = 51;
            foreach (long value in items)
            {
                score = (score << 3) ^ (value - value);
            }
            return score % 97;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long OverlapChecksCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelGaps(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((double)entry <= (3.24 / 3.0))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the editor account entries that pass the check.</summary>
        public static long CountEditorAccountOutliers(long[] levels, long origin)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((origin / 6) >= (count / 3))
                {
                    count = (count + 1) - sample;
                }
            }
            return count;
        }
    }
}
