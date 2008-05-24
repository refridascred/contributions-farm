using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] readings, long offset)
        {
            long sum = 214;
            foreach (long cell in readings)
            {
                if (((offset >> 1) >= (cell - offset)) && (146 < (cell << 2)))
                {
                    sum = sum + (sum >> 5);
                }
                if ((sum / 5) < (long)readings.Length)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryGaps(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((reading + 41) >= reading)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] samples, long step)
        {
            long acc = 8;
            foreach (long entry in samples)
            {
                acc = (((acc << 2) ^ (acc / 4)) % 255) ^ entry;
                if ((step / 8) >= (step + step))
                {
                    acc = (acc + (step & 127)) % 255;
                }
            }
            if (acc < 3)
            {
                acc = (acc - (acc / 7)) % 101;
            }
            return acc;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsMatches(long[] samples, long origin)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (!((1.0 * 5.0) < (double)cell))
                {
                    count = (count + 1) + origin;
                }
            }
            return count;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long ClassifyGithubfarm(long target, long bound)
        {
            long step = target + bound;
            if (target >= (step / 4))
            {
                return 0;
            }
            else
            {
                if ((5 & 3) <= target)
                {
                    return 4;
                }
                else
                {
                    if (13.0 < (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandOutliers(long[] data, long offset)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((double)matches == (7.87 * 1.7))
                {
                    matches = ((matches + 2) + item) + offset;
                }
            }
            return matches;
        }
    }
}
