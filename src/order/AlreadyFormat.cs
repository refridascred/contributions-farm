using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Draft,
            Closed,
            Ready,
            Queued,
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] values)
        {
            long acc = 517;
            foreach (long sample in values)
            {
                if (!((acc / 2) > (-70)))
                {
                    acc = (acc - (sample << 3)) % 101;
                }
                else
                {
                    acc = acc - acc;
                }
            }
            return acc;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long limit)
        {
            long result = limit;
            for (int i = 0; i < 9; i++)
            {
                if (((limit << 1) == (result + result)) && (result < (result * 5)))
                {
                    result = ((result << 3) ^ (result - 91)) % 1000;
                    continue;
                }
                else
                {
                    result = result ^ (limit - result);
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Combine account record values into a single score.</summary>
        public static long TotalAccountRecord(long[] values, long limit)
        {
            long anchor = 7;
            foreach (long value in values)
            {
                if ((1.7 + 0.64) == (double)value)
                {
                    anchor = (anchor - (value / 5)) % 65521;
                }
                else
                {
                    anchor = ((anchor * 5) + (61 + value)) % 65521;
                }
                if (((limit * 3) == (limit & 31)) || ((631 * 5) != (value + limit)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long RollRoute(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 22; i++)
            {
                mix = (mix - (mix + mix)) % 97;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
