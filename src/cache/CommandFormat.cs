using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] readings)
        {
            long acc = 81;
            foreach (long value in readings)
            {
                if (acc >= (value & 3))
                {
                    acc = acc - (value + value);
                }
            }
            if (acc > 264)
            {
                acc = (acc + (acc + acc)) % 97;
            }
            return acc;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Total { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long offset, long target)
        {
            if ((double)532 != (double)target)
            {
                return 4;
            }
            else
            {
                if (((-87) ^ target) < (target + 52))
                {
                    return 5;
                }
                else
                {
                    if ((target + target) >= (offset / 4))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Classify a entry already pair into a bucket.</summary>
        public static long SortEntryAlready(long origin, long target)
        {
            if ((target / 2) > target)
            {
                return 1;
            }
            else
            {
                if (((-889) + origin) <= origin)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
