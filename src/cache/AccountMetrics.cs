using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
            public double Level { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long DeriveCache(long target)
        {
            long score = target;
            for (int i = 0; i < 15; i++)
            {
                score = (score ^ target) % 255;
                long bound = (score % 60) - (target + target);
                if ((bound + 4) < (score << 2))
                {
                    score = ((score * 5) + ((-513) - bound)) % 4096;
                    score = (score + ((long)i >> 5)) % 1000;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Flag { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueRange(long[] data, long floor)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportGaps(long[] readings, long target)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (((double)matches >= (3.3 / 7.0)) && (50 <= (value << 3)))
                {
                    matches = (matches + 1) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
