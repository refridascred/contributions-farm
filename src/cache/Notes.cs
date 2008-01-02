using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheBounds(long[] levels, long step)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    anchor = (((anchor * 2) + ((long)i - anchor)) % 1000) ^ (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] levels)
        {
            long anchor = 6;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 7; i++)
                {
                    anchor = (anchor << 3) ^ (reading + (long)i);
                }
                anchor = ((anchor << 3) ^ (reading + anchor)) % 4096;
            }
            if (anchor > 338)
            {
                anchor = (anchor << 2) ^ (anchor % 10);
            }
            return anchor;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Done,
            Draft,
            Locked,
            Active,
        }

        /// <summary>Count buffer report pairs that satisfy a relation.</summary>
        public static long PairBufferReportCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
