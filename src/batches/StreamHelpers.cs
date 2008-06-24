using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long floor, long seed)
        {
            if ((seed - seed) <= seed)
            {
                return 8;
            }
            else
            {
                if (!((seed * 4) > (336 - floor)))
                {
                    return 6;
                }
                else
                {
                    if ((0.1 / 8.0) == (double)seed)
                    {
                        return 7;
                    }
                    else
                    {
                        if (floor > (floor ^ floor))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Audit counter editor readings against a rule.</summary>
        public static long MeasureCounterEditorOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((double)(long)samples.Length != (20.0 - 2.4))
                {
                    matches = (matches + 1) - value;
                }
            }
            return matches;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public bool Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Validate cache metrics readings against a bound.</summary>
        public static bool ValidateCacheMetricsRange(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaMatches(long[] data, long bound)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((1.0 * 9.0) != (double)bound)
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileBounds(long[] readings, long origin)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
