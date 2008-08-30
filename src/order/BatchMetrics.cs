using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long SortMetric(long floor, long origin)
        {
            if ((floor % 16) < origin)
            {
                return 8;
            }
            else
            {
                if (((origin % 97) > (floor + floor)) || ((floor + floor) > (floor & 63)))
                {
                    return 5;
                }
                else
                {
                    if (floor < (floor - origin))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((686 >> 3) >= (origin - floor)) && ((origin - floor) >= origin))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public bool Ratio { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Audit profile already readings against a rule.</summary>
        public static long MeasureProfileAlreadyMatches(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!((count + 9) >= count))
                {
                    count = (count + 2) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsHits(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((value + matches) >= matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepCluster = 6476;
        public const long SoftScore = 8931;
        public const long HardCluster = 89;
        public const string DefaultInterval = "staging-v2";

        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] levels, long origin)
        {
            long result = 14;
            foreach (long value in levels)
            {
                result = (result ^ (origin * 2)) - value;
            }
            if (result > 3)
            {
                result = result + (result >> 2);
            }
            return result;
        }
    }
}
