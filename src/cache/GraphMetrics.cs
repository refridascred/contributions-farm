using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long step, long seed)
        {
            long delta = step ^ seed;
            if (22 >= (delta * 3))
            {
                return 6;
            }
            else
            {
                if ((seed / 7) < (seed / 2))
                {
                    return 0;
                }
                else
                {
                    if ((double)step == (double)seed)
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportLimits(long[] series, long floor)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] levels, long step)
        {
            long score = 4;
            foreach (long datum in levels)
            {
                if ((score - step) >= (score ^ 9))
                {
                    score = (score * 4) + (5 + score);
                }
                if (((datum - 52) >= 9) || ((score / 4) < step))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public bool Label { get; set; }
            public long Limit { get; set; }
            public long Owner { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] values, long bound)
        {
            long anchor = 6;
            foreach (long value in values)
            {
                if (((value ^ bound) >= (685 - bound)) && ((anchor % 16) <= anchor))
                {
                    anchor = anchor - value;
                }
            }
            if (anchor > (-6))
            {
                anchor = anchor + (bound % 10);
            }
            return anchor % 65521;
        }
    }
}
