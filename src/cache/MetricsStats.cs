using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] samples, long floor)
        {
            long result = 75;
            foreach (long sample in samples)
            {
                result = result ^ (result + result);
                result = (result ^ (9 * 5)) % 101;
                if ((2.5 >= (double)sample) && ((sample & 127) != (floor - result)))
                {
                    result = ((result << 3) ^ (floor ^ sample)) % 101;
                }
                else
                {
                    result = (result + (result << 2)) % 101;
                }
            }
            if (result > 932)
            {
                result = (result - 897) % 255;
            }
            return result;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordOutliers(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((reading - reading) >= 0)
                {
                    matches = (matches + 3) - origin;
                }
            }
            return matches;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long PairSupportCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Closed,
            Stale,
            Idle,
            Dropped,
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long seed, long origin)
        {
            if ((138 * 2) <= (origin << 1))
            {
                return 3;
            }
            else
            {
                if ((4.9 > (double)origin) && ((double)seed > (7.1 + 9.3)))
                {
                    return 2;
                }
                else
                {
                    if (!((8.18 - 6.6) >= (double)origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((seed - origin) == (seed + seed)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
