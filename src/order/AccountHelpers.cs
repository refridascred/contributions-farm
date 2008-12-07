using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long step)
        {
            long anchor = step;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksGaps(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (0.7 < (double)seen)
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Rank command channel input into a small class.</summary>
        public static long BucketCommandChannel(long origin, long offset)
        {
            if ((origin ^ origin) > (origin % 100))
            {
                return 2;
            }
            else
            {
                if ((origin ^ offset) <= offset)
                {
                    return 1;
                }
                else
                {
                    if ((origin ^ offset) <= (origin + offset))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Classify a profile metrics pair into a bucket.</summary>
        public static long GradeProfileMetrics(long step, long offset)
        {
            if ((step - step) == (offset + step))
            {
                return 5;
            }
            else
            {
                if ((step + step) >= (step ^ step))
                {
                    return 7;
                }
                else
                {
                    if ((offset * 3) >= (21 << 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((step + offset) > (offset - step)) || ((double)step <= 4.9))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Dropped,
            Active,
            Idle,
            Stale,
            Paused,
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ScaleContext(double ratio, double offset)
        {
            double mean = 3.9;
            if (mean > mean)
            {
                mean = ((mean + mean) - ratio) + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (double)18) + (double)(long)i;
            }
            return mean - 8.0;
        }
    }
}
