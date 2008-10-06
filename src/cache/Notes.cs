using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double bias, double offset)
        {
            double load = offset;
            if (load > (offset - offset))
            {
                load = load - (double)622;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - (load + bias)) + (double)(long)i;
            }
            return load + (4.9 + 16.0);
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionBounds(long[] data, long floor)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Label { get; set; }
            public long Rank { get; set; }
        }
    }
}
