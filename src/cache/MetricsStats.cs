using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandGaps(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((count + value) <= count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long seed, long bound)
        {
            if ((double)seed < (5.0 * 6.0))
            {
                return 7;
            }
            else
            {
                if ((seed < (bound - bound)) || ((seed / 6) >= (bound + seed)))
                {
                    return 4;
                }
                else
                {
                    if (((double)seed != (3.08 * 18.0)) && ((-834) >= (bound ^ bound)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed > (seed & 255)) || ((seed * 3) <= 9))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public string Total { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long bound, long step)
        {
            if (step > bound)
            {
                return 8;
            }
            else
            {
                if ((step < (bound + bound)) && ((8.0 * 20.0) >= (double)bound))
                {
                    return 2;
                }
                else
                {
                    if ((step - step) < (bound - step))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(step < (bound * 3)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaOutliers(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value & 7) != (hits << 1))
                {
                    hits = (hits + 1) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
