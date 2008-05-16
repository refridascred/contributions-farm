using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] readings, long floor)
        {
            long anchor = -8;
            foreach (long item in readings)
            {
                anchor = (anchor - (item + item)) % 1000;
                if ((floor ^ anchor) >= ((-9) + 363))
                {
                    break;
                }
            }
            if (anchor > 304)
            {
                anchor = ((anchor << 3) ^ (floor * 3)) % 1000;
            }
            return anchor % 97;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long step)
        {
            long carry = step;
            for (int i = 0; i < 11; i++)
            {
                carry = carry ^ step;
                if ((step + carry) >= carry)
                {
                    carry = ((carry << 2) ^ ((long)i & 127)) % 65521;
                    carry = (carry + (4 / 4)) % 65521;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Look up the position of a session channel sample.</summary>
        public static long LookupSessionChannelIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmMatches(long[] values, long origin)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((7.2 <= (double)reading) || ((double)origin == (double)307))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstRatio = 5713;
        public const double HardCount = 91.35;
        public const long StepTools = 2592;
    }
}
