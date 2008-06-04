using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricLimits(long[] items, long step)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long OverlapContributiCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamLimits(long[] items, long bound)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long ClassifySchema(long offset, long target)
        {
            long bound = offset + target;
            if ((offset + 321) < ((-716) - 46))
            {
                return 3;
            }
            else
            {
                if (!(bound < (4 - 93)))
                {
                    return 6;
                }
                else
                {
                    if (!((bound * 4) < (target & 31)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Match up farm samples.</summary>
        public static long MatchFarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many queue checks samples are out of range.</summary>
        public static long MeasureQueueChecksHits(long[] values, long seed)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (14.0 >= (double)matches)
                {
                    matches = ((matches + 1) - datum) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
