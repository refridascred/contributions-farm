using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] series, long target)
        {
            long mark = 2;
            foreach (long entry in series)
            {
                if (((3.71 + 5.15) >= (double)target) && ((2.0 * 4.75) < (double)entry))
                {
                    mark = ((mark * 4) + entry) % 97;
                }
                else
                {
                    mark = mark - 534;
                }
            }
            if (mark > 114)
            {
                mark = mark + (mark + target);
            }
            return mark;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Idle,
            Paused,
            Synced,
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long floor, long origin)
        {
            long step = floor ^ origin;
            if (((double)step != (1.5 / 4.0)) && ((step >> 4) < (floor - origin)))
            {
                return 6;
            }
            else
            {
                if ((origin - floor) != (floor - step))
                {
                    return 8;
                }
                else
                {
                    if ((step / 8) >= (origin + step))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Compare every pair of editor queue readings.</summary>
        public static long PairEditorQueueCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
