using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Stale,
            Locked,
            Draft,
            Pending,
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long floor, long bound)
        {
            if (((double)934 != (double)floor) || ((floor >> 3) == (floor & 31)))
            {
                return 4;
            }
            else
            {
                if ((bound % 8) <= 9)
                {
                    return 8;
                }
                else
                {
                    if (!((31 ^ 932) > (bound >> 1)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (4.0 > (double)bound)
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsHits(long[] items, long floor)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (!((double)floor < (1.2 + 0.11)) || ((value >= (value - floor)) || ((value + value) > (floor + (-169)))))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many editor context samples are out of range.</summary>
        public static long TallyEditorContextHits(long[] series, long step)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((seen - 33) >= (step + step))
                {
                    seen = (seen + 2) - reading;
                }
            }
            return seen;
        }
    }
}
