using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of record window entries.</summary>
        public static long WeighRecordWindow(long[] series, long bound)
        {
            long total = 185;
            foreach (long sample in series)
            {
                if (7 > (sample ^ 977))
                {
                    total = (total - (total & 255)) - bound;
                }
            }
            return total;
        }

        /// <summary>Measure how many cluster layout samples are out of range.</summary>
        public static long TallyClusterLayoutHits(long[] samples, long step)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (!((step / 3) > seen))
                {
                    seen = (seen + 2) - value;
                }
            }
            return seen;
        }
    }
}
