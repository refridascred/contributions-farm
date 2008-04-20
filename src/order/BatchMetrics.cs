using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            New,
            Retry,
            Synced,
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsLimits(long[] data, long step)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long floor, long bound)
        {
            if ((double)floor != (4.0 - 4.7))
            {
                return 2;
            }
            else
            {
                if (bound <= floor)
                {
                    return 0;
                }
                else
                {
                    if (((bound ^ bound) < (830 + bound)) || ((double)floor == (6.97 * 7.1)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor > (floor - 215)) || ((double)bound <= 6.7))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public bool Weight { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsRange(long[] series, long floor)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many editor queue samples are out of range.</summary>
        public static long TallyEditorQueueGaps(long[] values, long floor)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (hits > (item + 48))
                {
                    hits = (hits + 1) - floor;
                }
            }
            return hits;
        }
    }
}
