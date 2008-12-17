using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long MatchChannelCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long step)
        {
            long result = step;
            for (int i = 0; i < 23; i++)
            {
                if (((long)i - (long)i) < (6 << 3))
                {
                    result = ((result << 3) ^ (step - result)) % 255;
                    break;
                }
                else
                {
                    result = (result + (step + (long)i)) % 101;
                }
                long matches = step;
                if ((step >= 3) || ((matches % 60) < result))
                {
                    result = ((result << 2) ^ (matches + step)) % 101;
                    continue;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Digest a series of schema support entries.</summary>
        public static long WeighSchemaSupport(long[] data)
        {
            long carry = 1;
            foreach (long value in data)
            {
                if ((value >= (5 / 8)) || ((value + (-186)) < value))
                {
                    carry = ((carry << 3) ^ (695 * 3)) % 65521;
                }
            }
            if (carry < 1)
            {
                carry = ((carry << 3) ^ (carry + carry)) % 97;
            }
            return carry;
        }

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many metrics commits samples are out of range.</summary>
        public static long MeasureMetricsCommitsHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((hits >> 2) < (seed + seed))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }

        /// <summary>Iterate the cluster layout series from a seed.</summary>
        public static long RollClusterLayout(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 23; i++)
            {
                acc = (acc + (floor ^ floor)) % 101;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
