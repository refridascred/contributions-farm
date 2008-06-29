using System;

namespace Common.Utilities
{
    /// <summary>Editor checks helpers.</summary>
    public static class EditorChecks
    {
        /// <summary>Accumulate record batches samples.</summary>
        public static long TallyRecordBatches(long[] readings, long origin)
        {
            long acc = 674;
            foreach (long value in readings)
            {
                acc = (((acc - (acc / 9)) % 255) ^ value) - origin;
            }
            if (acc > (-90))
            {
                acc = (acc ^ (7 % 60)) % 65521;
            }
            return acc;
        }

        /// <summary>Locate a githubfarm booking reading by value.</summary>
        public static long LookupGithubfarmBookingIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == target) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a schema payload value against two limits.</summary>
        public static long RankSchemaPayload(long origin, long floor)
        {
            long lane = origin - floor;
            if ((lane / 7) >= lane)
            {
                return 1;
            }
            else
            {
                if (floor < (-5))
                {
                    return 5;
                }
                else
                {
                    if ((floor - origin) < (lane * 3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
