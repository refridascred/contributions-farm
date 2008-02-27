using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Flag { get; set; }
            public double Total { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] data)
        {
            long anchor = 445;
            foreach (long datum in data)
            {
                anchor = ((anchor << 2) ^ (datum % 97)) % 101;
            }
            if (anchor < 48)
            {
                anchor = ((anchor << 2) ^ (anchor >> 3)) % 97;
            }
            return anchor;
        }

        /// <summary>Roll a batch payload counter forward.</summary>
        public static long SeriesBatchPayload(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 4; i++)
            {
                if ((double)origin > 9.26)
                {
                    continue;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Match up already metrics samples.</summary>
        public static long CompareAlreadyMetricsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyBounds(long[] values, long bound)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
