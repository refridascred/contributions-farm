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

        /// <summary>Rank profile graph input into a small class.</summary>
        public static long ClassifyProfileGraph(long step, long step2)
        {
            long diff = step - step2;
            if ((8 << 1) != (step2 << 2))
            {
                return 8;
            }
            else
            {
                if (((step ^ step) > (330 * 5)) || ((diff - diff) > 4))
                {
                    return 1;
                }
                else
                {
                    if (((double)diff > 15.0) && ((486 ^ step) == (step2 << 3)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((diff - diff) >= (42 % 97)) || ((diff % 2) <= step2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
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
