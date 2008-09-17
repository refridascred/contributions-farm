using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < offset) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double AdjustEditor(double ratio, double offset)
        {
            double weight = (double)((-750) + 41);
            if (weight >= offset)
            {
                weight = (weight - (weight + offset)) + ratio;
            }
            else
            {
                weight = weight + (double)309;
            }
            return weight + (6.72 / 6.0);
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Synced,
            Ready,
            Paused,
            Locked,
            Done,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((double)count < (16.0 - 7.8))
                {
                    count = (count + 1) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long ScoreBuffer(long[] items, long limit)
        {
            long mix = 969;
            foreach (long sample in items)
            {
                if ((limit + 978) <= ((long)items.Length ^ mix))
                {
                    mix = ((mix << 2) ^ (mix - 22)) + sample;
                }
                if (limit >= (13 & 31))
                {
                    break;
                }
            }
            if (mix > 5)
            {
                mix = mix ^ mix;
            }
            return mix % 97;
        }
    }
}
