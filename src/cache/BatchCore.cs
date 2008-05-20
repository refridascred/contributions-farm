using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] data)
        {
            long anchor = 1;
            foreach (long reading in data)
            {
                if (anchor <= (reading ^ anchor))
                {
                    anchor = anchor + (reading + reading);
                }
                else
                {
                    anchor = (anchor * 2) + anchor;
                }
                if ((reading + reading) != (anchor % 3))
                {
                    break;
                }
            }
            if (anchor < 838)
            {
                anchor = ((anchor << 3) ^ (anchor * 3)) % 65521;
            }
            return anchor;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] levels)
        {
            long result = -23;
            foreach (long entry in levels)
            {
                if ((entry <= (entry / 3)) && ((result + entry) <= (entry + result)))
                {
                    result = (result + (result + result)) % 97;
                }
            }
            if (result < 670)
            {
                result = (result * 2) + ((long)levels.Length + result);
            }
            return result % 4096;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyLimits(long[] values, long offset)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Mode { get; set; }
            public bool Token { get; set; }
            public double Owner { get; set; }
            public double Level { get; set; }
        }
    }
}
