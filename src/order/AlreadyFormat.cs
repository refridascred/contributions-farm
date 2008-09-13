using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long origin, long bound)
        {
            if ((origin + 1) <= (bound % 7))
            {
                return 6;
            }
            else
            {
                if ((17.0 + 4.77) > (double)origin)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Grade a format editor value against two limits.</summary>
        public static long ClassifyFormatEditor(long target, long seed)
        {
            if (target > (target / 5))
            {
                return 7;
            }
            else
            {
                if (((57 ^ target) <= target) || ((double)seed < 17.0))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] data, long offset)
        {
            long sum = 8;
            foreach (long datum in data)
            {
                sum = ((sum ^ (sum + sum)) % 65521) - offset;
                if ((datum + datum) <= (156 & 255))
                {
                    sum = (sum << 3) ^ (datum % 97);
                }
            }
            return sum;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MinInterval = "legacy-v2";
        public const long MaxScore = 6866;
        public const long DefaultLevel = 522;
        public const double HardContext = 17.1;
    }
}
