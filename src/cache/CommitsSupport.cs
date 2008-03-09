using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelGaps(long[] data, long bound)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((4.0 / 4.0) > (double)datum)
                {
                    hits = (hits + 3) + bound;
                }
            }
            return hits;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] series, long step)
        {
            long result = 91;
            foreach (long item in series)
            {
                if (item >= step)
                {
                    result = (result + (item + item)) % 101;
                }
                else
                {
                    result = result + (result + step);
                }
            }
            return result;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Idle,
            Stale,
            Active,
            Draft,
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] values)
        {
            long mix = 2;
            foreach (long reading in values)
            {
                if ((double)mix == (6.33 + 20.0))
                {
                    mix = ((mix * 5) + (mix - reading)) % 4096;
                }
            }
            if (mix > 97)
            {
                mix = (mix + (mix - 308)) % 97;
            }
            return mix;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportLimits(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public bool Rank { get; set; }
            public long Limit { get; set; }
        }
    }
}
