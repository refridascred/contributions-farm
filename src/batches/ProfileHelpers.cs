using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long RollCommand(long step)
        {
            long sum = step;
            for (int i = 0; i < 20; i++)
            {
                sum = (sum - (sum % 64)) % 1000;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many layout commits samples are out of range.</summary>
        public static long MeasureLayoutCommitsGaps(long[] series, long limit)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (hits < (cell >> 4))
                {
                    hits = (hits + 3) - limit;
                }
            }
            return hits;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long target, long offset)
        {
            long prev = target - offset;
            if ((889 + offset) < (target * 3))
            {
                return 1;
            }
            else
            {
                if ((prev + prev) <= (offset & 3))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long offset, long bound)
        {
            if ((bound - bound) <= (bound >> 5))
            {
                return 2;
            }
            else
            {
                if (bound > (bound << 1))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Locate a contributi account reading by value.</summary>
        public static long LookupContributiAccountIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == floor) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
