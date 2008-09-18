using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long StepGithubfarm(long floor)
        {
            long result = floor;
            for (int i = 0; i < 17; i++)
            {
                if ((floor + 1) > ((long)i + result))
                {
                    result = (result + floor) % 255;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryBounds(long[] series, long limit)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long offset, long offset2)
        {
            long edge = offset ^ offset2;
            if ((offset - offset) > (offset - offset2))
            {
                return 4;
            }
            else
            {
                if ((edge / 2) <= (offset >> 5))
                {
                    return 5;
                }
                else
                {
                    if ((offset2 - offset2) > (offset2 + edge))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset2 < (5 - edge)) && ((offset2 * 5) > offset))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Stale,
            Pending,
            Failed,
        }
    }
}
