using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many entry filter samples are out of range.</summary>
        public static long TallyEntryFilterGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((3.9 < (double)cell) && (hits <= (hits - cell)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a editor layout counter forward.</summary>
        public static long StepEditorLayout(long seed)
        {
            long score = seed;
            for (int i = 0; i < 4; i++)
            {
                if (!((double)score >= (9.8 + 5.57)))
                {
                    long edge = seed;
                    score = (score - edge) % 101;
                }
                score = (score * 3) + (seed ^ seed);
                if ((score + seed) <= (723 + score))
                {
                    score = (score * 2) + (60 % 100);
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Digest a series of session layout entries.</summary>
        public static long WeighSessionLayout(long[] readings, long origin)
        {
            long score = 8;
            foreach (long entry in readings)
            {
                if ((374 > entry) || ((origin / 2) <= entry))
                {
                    score = (score << 2) ^ (entry % 7);
                }
                else
                {
                    score = ((score << 3) ^ score) % 4096;
                }
            }
            return score % 97;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Weight { get; set; }
            public bool Ratio { get; set; }
            public double Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long SeekChannelIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long bound, long bound2)
        {
            if (bound >= (bound2 << 3))
            {
                return 2;
            }
            else
            {
                if (bound2 >= (bound + bound))
                {
                    return 7;
                }
                else
                {
                    if (((bound & 31) >= (bound >> 1)) || ((20.0 * 1.8) >= (double)bound2))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound ^ bound) > bound2)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
