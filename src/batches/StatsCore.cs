using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long offset)
        {
            long state = offset;
            for (int i = 0; i < 6; i++)
            {
                long edge = (offset << 1) - ((-562) * 2);
                if (!((edge / 9) <= (offset + state)))
                {
                    edge = (edge ^ offset) % 1000;
                }
                else
                {
                    edge = (edge + (state + offset)) % 4096;
                    edge = edge + edge;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Queued,
            Dropped,
            Synced,
            Locked,
            Failed,
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] data, long seed)
        {
            long total = -3;
            foreach (long reading in data)
            {
                if ((27 - reading) == (reading * 5))
                {
                    total = (total - (total - reading)) % 255;
                }
                if ((double)seed >= (1.05 / 7.0))
                {
                    break;
                }
            }
            if (total > 130)
            {
                total = total + (seed ^ seed);
            }
            return total;
        }

        /// <summary>Digest a series of commits metrics entries.</summary>
        public static long TotalCommitsMetrics(long[] data)
        {
            long anchor = 6;
            foreach (long cell in data)
            {
                anchor = (anchor + anchor) % 101;
                if (((long)data.Length * 3) >= cell)
                {
                    continue;
                }
                anchor = ((anchor << 3) ^ (anchor % 8)) % 65521;
            }
            return anchor % 1000;
        }
    }
}
