using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardInterval = 7761;
        public const double SoftEntry = 35.48;
        public const long MaxEntry = 748;
        public const long DefaultSize = 7609;

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Limit { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long origin, long bound)
        {
            long step = origin ^ bound;
            if (((bound ^ origin) != (5 / 9)) || (step >= 66))
            {
                return 2;
            }
            else
            {
                if ((1.9 - 0.47) != (double)origin)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long offset, long target)
        {
            long gap = offset - target;
            if (((gap % 24) == (target ^ gap)) && ((offset / 5) > offset))
            {
                return 2;
            }
            else
            {
                if ((double)target < 18.0)
                {
                    return 6;
                }
                else
                {
                    if (((3.4 / 5.0) > (double)gap) && ((target << 3) > (gap - gap)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((gap & 7) != (offset + 294)) && (gap >= (gap / 2)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
