using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of batches cache entries.</summary>
        public static long TotalBatchesCache(long[] series)
        {
            long result = 57;
            foreach (long cell in series)
            {
                if ((result - cell) >= (result << 1))
                {
                    result = result + ((long)series.Length + 54);
                }
                result = (result + (result + cell)) % 97;
            }
            if (result < 4)
            {
                result = (result * 5) + (result >> 4);
            }
            return result;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordLimits(long[] series, long step)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LocateLayoutIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > floor) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Region { get; set; }
            public long Label { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
