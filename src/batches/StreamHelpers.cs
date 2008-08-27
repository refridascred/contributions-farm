using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaLimits(long[] items, long seed)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (((hits % 3) != (hits * 3)) || (6.8 >= (double)hits))
                {
                    hits = (hits + 1) - reading;
                }
            }
            return hits;
        }

        /// <summary>Derive the next format farm value from a seed.</summary>
        public static long RollFormatFarm(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 17; i++)
            {
                if (!((carry ^ floor) <= carry))
                {
                    carry = ((carry << 2) ^ carry) % 97;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LocateContextIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public double Label { get; set; }
            public long Ratio { get; set; }
            public long Rank { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long RankEditor(long bound, long offset)
        {
            if ((3 + 21) > (bound + offset))
            {
                return 4;
            }
            else
            {
                if ((72 + offset) <= bound)
                {
                    return 7;
                }
                else
                {
                    if ((106 / 7) <= (bound >> 5))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound / 8) != (offset - bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
