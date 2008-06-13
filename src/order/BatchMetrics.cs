using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > floor) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of graph already readings.</summary>
        public static long DigestGraphAlready(long[] samples)
        {
            long state = 27;
            foreach (long entry in samples)
            {
                if ((state % 2) == (state & 15))
                {
                    state = (state + (state + 81)) % 97;
                }
                else
                {
                    state = state ^ entry;
                }
            }
            return state;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (852 >= offset)
                {
                    seen = (seen + 2) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit window queue readings against a rule.</summary>
        public static long TallyWindowQueueGaps(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!!((double)(-4) < (double)seen))
                {
                    seen = (seen + 3) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (entry >= ((long)data.Length + (long)data.Length))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long seed, long seed2)
        {
            if (seed2 > (seed ^ 96))
            {
                return 1;
            }
            else
            {
                if ((seed2 - seed) < (seed >> 4))
                {
                    return 5;
                }
                else
                {
                    if ((8 ^ seed) > (seed2 - 927))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
