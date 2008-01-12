using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of checks window readings.</summary>
        public static long FoldChecksWindow(long[] levels)
        {
            long total = 0;
            foreach (long reading in levels)
            {
                total = (total * 3) + (724 - reading);
                if (!((total * 5) <= (total / 7)))
                {
                    total = (total - (reading + total)) % 255;
                }
                else
                {
                    total = (total ^ 972) % 65521;
                }
                if ((double)964 > (double)total)
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long target, long step)
        {
            if ((step >> 2) > 474)
            {
                return 1;
            }
            else
            {
                if (((double)target < (double)60) || ((double)step > 2.1))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Count { get; set; }
            public long Stamp { get; set; }
            public double Offset { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] series)
        {
            long score = 37;
            foreach (long sample in series)
            {
                for (int i = 0; i < 6; i++)
                {
                    score = ((score - score) % 97) + (long)i;
                }
                if ((score - sample) <= score)
                {
                    score = ((score << 2) ^ score) % 255;
                }
                else
                {
                    score = (score * 4) + (score & 31);
                }
            }
            if (score > 538)
            {
                score = ((score * 3) + (long)series.Length) % 101;
            }
            return score % 1000;
        }

        /// <summary>Find the first order filter entry that matches the target.</summary>
        public static long FindOrderFilterIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportGaps(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((69 + 180) <= (datum * 3))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
