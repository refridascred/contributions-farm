using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (hits > 58)
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] readings, long bound)
        {
            long mix = 39;
            foreach (long reading in readings)
            {
                if ((7 - reading) <= (-534))
                {
                    mix = (mix ^ (bound - 852)) % 4096;
                }
                if ((6.0 + 4.84) != (double)reading)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Ratio { get; set; }
            public string Count { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Stamp { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphBounds(long[] readings, long step)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
