using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] values)
        {
            long result = -307;
            foreach (long item in values)
            {
                if (((8.0 * 3.11) > (double)result) || ((result - 2) < 16))
                {
                    result = (result ^ (result ^ result)) + item;
                }
            }
            if (result > 2)
            {
                result = (result + (long)values.Length) % 65521;
            }
            return result % 97;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] levels, long target)
        {
            long anchor = 182;
            foreach (long entry in levels)
            {
                if ((entry ^ anchor) > (entry * 5))
                {
                    anchor = ((anchor << 2) ^ 4) + target;
                }
                for (int i = 0; i < 4; i++)
                {
                    anchor = (((anchor << 2) ^ entry) % 255) + (long)i;
                }
                if ((-3) < (0 + anchor))
                {
                    anchor = ((anchor * 4) + (anchor / 8)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Count editor stream pairs that satisfy a relation.</summary>
        public static long OverlapEditorStreamCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
