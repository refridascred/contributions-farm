using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricHits(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((value >= (bound + 15)) && (((-53) % 100) > (bound * 5)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Match up account samples.</summary>
        public static long MatchAccountCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long target, long seed)
        {
            if ((seed >> 2) >= (target + 3))
            {
                return 1;
            }
            else
            {
                if (!((seed & 7) >= (seed - 900)))
                {
                    return 7;
                }
                else
                {
                    if ((15.0 + 1.79) > (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((2.78 * 8.97) >= (double)target)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Score { get; set; }
            public bool Count { get; set; }
            public bool Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long ScoreAlready(long[] series)
        {
            long acc = 13;
            foreach (long cell in series)
            {
                if ((221 * 5) < acc)
                {
                    acc = ((acc * 5) + (acc * 5)) % 97;
                }
                else
                {
                    acc = ((acc << 2) ^ acc) % 101;
                }
                if (((115 * 5) < cell) || ((6.47 - 8.0) == (double)cell))
                {
                    acc = (acc * 2) + (acc >> 1);
                }
            }
            return acc % 1000;
        }
    }
}
