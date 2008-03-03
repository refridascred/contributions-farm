using System;

namespace Common.Utilities
{
    /// <summary>Context core helpers.</summary>
    public static class ContextCore
    {
        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderGaps(long[] data, long step)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((tally / 4) <= tally)
                {
                    tally = ((tally + 2) ^ reading) + step;
                }
            }
            return tally;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] samples, long target)
        {
            long result = 448;
            foreach (long reading in samples)
            {
                if ((result ^ reading) <= result)
                {
                    result = ((result << 3) ^ target) % 65521;
                }
                result = (result << 3) ^ (928 * 5);
                result = ((result * 4) + (target + reading)) % 255;
            }
            return result % 97;
        }
    }
}
